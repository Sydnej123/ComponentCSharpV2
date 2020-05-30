using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace FormComponent
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    /// <summary>Form controller. Container for designed inputs. </summary>
    public partial class Form : UserControl
    {

        private string _json = "";
        /// <value>Gets data in json format</value>
        public string JSONData
        {
            get { return _json; }

        }
        private Label formName = new Label();

        /// <value>Gets and sets name of form</value>
        public String FormName
        {
            get { return formName.Text;  }
            set { formName.Text = value;  }
        }

        /// <value>Gets and sets color of form name</value>
        public Color FormNameColor
        {
            get { return formName.ForeColor;  }
            set { formName.ForeColor = value;  }
        }

        private int _currentPadding = 0;

        /// <value>Gets and sets top margin of form name</value>
        public int FormNameMarginTop
        {
            get { return formName.Padding.Top; }
            set { formName.Padding = new Padding(0,value,0,0);
                formName.Size = new Size(formName.Size.Width, formName.Size.Height + value - _currentPadding);
                _currentPadding = value;
            }
        }


        
        private Point _errorPosition = new Point(0,20);
        /// <value>Gets and sets error position for all inputs in container</value>
        public Point ErrorPosition
        {
            get { return _errorPosition; }
            set
            {
                _errorPosition = value;
                revalidateGrid();
            }
        }

        private Size _errorSize = new Size(200,20);
        /// <value>Gets and sets error size for all inputs in container</value>
        public Size ErrorSize
        {
            get { return _errorSize; }
            set
            {
                _errorSize = value;
                revalidateGrid();
            }
        }

        private Size _fieldsSize = new Size(200, 40);
        /// <value>Gets and sets field size for all inputs in container</value>
        public Size FieldsSize
        {
            get { return _fieldsSize; }
            set
            {
                _fieldsSize = value;
                revalidateGrid();
            }
        }

        private bool _controlGrid = false;
        /// <value>Gets and sets if grid of controlls should be controlled by form</value>
        public bool ControlGrid
        {
            get { return _controlGrid; }
            set { _controlGrid = value;
                
                    revalidateGrid();
               
            }
        }

        private int _marginLeft = 0;
        /// <value>Gets and sets left margin for all inputs in container</value>
        public int ControlsMarginLeft
        {
            get { return _marginLeft; }
            set { _marginLeft = value;
                revalidateGrid();
            }
        }

        private int _marginTop = 0;
        /// <value>Gets and sets top margin for all inputs in container</value>
        public int ControlsMarginTop
        {
            get { return _marginTop; }
            set { _marginTop = value;
                revalidateGrid();
            }
        }

        private int _marginRight = 0;
        /// <value>Gets and sets right margin for all inputs in container</value>
        public int ControlsMarginRight
        {
            get { return _marginRight; }
            set { _marginRight = value;
                revalidateGrid();
            }
        }

        private int _marginBottom = 0;
        /// <value>Gets and sets bottom margin for all inputs in container</value>
        public int ControlsMarginBottom
        {
            get { return _marginBottom; }
            set { _marginBottom = value;
                revalidateGrid();
            }
        }

        private bool _controlsSizeFillToParent = false;
        /// <value>Gets and sets if controls size should be fitted to paren</value>
        public bool ControlsSizeFillToParent
        {
            get { return _controlsSizeFillToParent; }
            set { _controlsSizeFillToParent = value;
                revalidateGrid();
            }
        }

        private Color _errorForeColor = Color.Red;
        /// <value>Gets and sets error fore color for all inputs in container</value>
        private Color ErrorForeColor
        {
            get { return _errorForeColor;  }
            set { _errorForeColor = value;
                    revalidateGrid();
            }
        }
        /// <summary>
        /// Revalidating grid of controlls
        /// </summary>
        public void revalidateGrid()
        {
            if (_controlGrid) {
                int i = 0;
                int currentHeight = 0;

                List<Control> con = Controls.Cast<Control>().OrderBy(control => control.Location.Y).ToList();
                foreach (Control c in con)
                {

                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        obj.setSize(_fieldsSize);
                        if (i == 0)
                        {
                            Point point = obj.getLocation();
                            currentHeight = point.Y;
                        }
                        obj.setErrorPosition(_errorPosition);
                        obj.setErrorSize(_errorSize);
                        obj.setErrorColor(_errorForeColor);
                        if (ControlsSizeFillToParent)
                        {
                            obj.setLocation(new Point(_marginLeft, currentHeight));
              
                            _fieldsSize = new Size(this.Width - _marginLeft - _marginRight, _fieldsSize.Height);
                            obj.setSize(_fieldsSize);

                        }
                        else
                        {
                            obj.setLocation(new Point(_marginLeft, currentHeight));
                            obj.setSize(_fieldsSize);
                        }

                        
                        
                        currentHeight += (_fieldsSize.Height + _marginTop + _marginBottom);
                        i++;
                    }
                   
                }
            }
          
        }
       







        public Form()
        {
            
            initForm();
            InitializeComponent();
        }

        public Form(IContainer container)
        {
            initForm();
            container.Add(this);
            InitializeComponent();
        }

        /// <summary>
        /// Initialization of form
        /// </summary>
        public void initForm()
        {
            formName.Dock = DockStyle.Top;
            formName.TextAlign = ContentAlignment.MiddleCenter;
            
            this.Controls.Add(formName);
            this.Resize += revalidate;
        }

        /// <summary>
        /// Revalidate grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revalidate(object sender, EventArgs e)
        {
            revalidateGrid();
        }
        /// <summary>
        /// Checks if all inputs have valid value
        /// </summary>
        /// <returns>Returns true if form is valid</returns>
        public bool validateForm()
        {
            bool isFormValid = true;

            foreach (Control c in Controls)
            {
                IFormInput obj = c as IFormInput;
                if (obj != null)
                {
                    if (!obj.isValid())
                    {
                        isFormValid = false;
                    }
                }
            }
            return isFormValid;
        }

        /// <summary>
        /// Gets data from form and creating string
        /// </summary>
        /// <returns>Form data in string format</returns>
        public String getDataString() {
            string data = "{";
            if (validateForm())
            {
                foreach (Control c in Controls)
                {
                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        data += obj.getName() + ":" + "\"" + obj.getValue() + "\",";
                    }
                }
                if (data.EndsWith(",")) {
                    data = data.Substring(0, data.Length - 1);
                }
                return data + "}";
            }
            else {
                return "Error";
           }
        }

        /// <summary>
        /// Gets data from form in Dictionary format.
        /// </summary>
        /// <returns>Dictionary of fieldName : value</returns>
        public Dictionary<string, string> getData()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            if (validateForm())
            {
                foreach (Control c in Controls)
                {
                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        values.Add(obj.getName(), obj.getValue());
                    }
                }
                
            }
            return values;
        }

        /// <summary>
        /// Sets default value for all fields in form
        /// </summary>
        public void clearFields()
        {
            foreach (Control c in Controls)
            {
                IFormInput obj = c as IFormInput;
                if (obj != null)
                {
                    obj.clearField();
                }
            }
        }
            

    }
}
