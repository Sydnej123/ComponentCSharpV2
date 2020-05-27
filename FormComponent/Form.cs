using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace FormComponent
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    public partial class Form : UserControl
    {

        private string _json = "";
        public string JSONData
        {
            get { return _json; }

        }

        private Point _errorPosition = new Point(0,20);
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
        public bool ControlGrid
        {
            get { return _controlGrid; }
            set { _controlGrid = value;
                
                    revalidateGrid();
               
            }
        }

        private int _marginLeft = 0;
        public int ControlsMarginLeft
        {
            get { return _marginLeft; }
            set { _marginLeft = value;
                revalidateGrid();
            }
        }

        private int _marginTop = 0;
        public int ControlsMarginTop
        {
            get { return _marginTop; }
            set { _marginTop = value;
                revalidateGrid();
            }
        }

        private int _marginRight = 0;
        public int ControlsMarginRight
        {
            get { return _marginRight; }
            set { _marginRight = value;
                revalidateGrid();
            }
        }

        private int _marginBottom = 0;
        public int ControlsMarginBottom
        {
            get { return _marginBottom; }
            set { _marginBottom = value;
                revalidateGrid();
            }
        }

        private bool _controlsSizeFillToParent = false;
        public bool ControlsSizeFillToParent
        {
            get { return _controlsSizeFillToParent; }
            set { _controlsSizeFillToParent = value;
                revalidateGrid();
            }
        }


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
                            currentHeight = point.Y + _marginTop;
                        }
                        obj.setErrorPosition(_errorPosition);
                        obj.setErrorSize(_errorSize);

                        if (ControlsSizeFillToParent)
                        {
                           
                            
                            obj.setLocation(new Point(_marginLeft, currentHeight));
                            obj.setSize(new Size(this.Parent.Width - _marginLeft - _marginRight, _fieldsSize.Height));

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
            InitializeComponent();
        }

        public Form(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

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
