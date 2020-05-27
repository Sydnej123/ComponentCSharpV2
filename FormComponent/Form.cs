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

        private Point _errorPosition;
        public Point ErrorPosition
        {
            get { return _errorPosition; }
            set
            {
                _errorPosition = value;
                foreach (Control c in Controls)
                {
                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        obj.setErrorPosition(value);
                    }
                }
            }
        }

        private Size _errorSize;
        public Size ErrorSize
        {
            get { return _errorSize; }
            set
            {
                _errorSize = value;
                foreach (Control c in Controls)
                {
                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        obj.setErrorSize(value);
                    }
                }
            }
        }

        private Size _fieldsSize;
        public Size FieldsSize
        {
            get { return _fieldsSize; }
            set
            {
                _fieldsSize = value;
                foreach (Control c in Controls)
                {
                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        obj.setInputSize(value);
                    }
                }
            }
        }

        private bool _controlGrid = false;
        public bool ControlGrid
        {
            get { return _controlGrid; }
            set { _controlGrid = value;
                if (value)
                {
                    revalidateGrid();
                }
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
                            currentHeight = point.Y;
                        }
                        obj.setLocation(new Point(_marginLeft, currentHeight));
                        currentHeight += (_fieldsSize.Height + _marginTop);
                        i++;
                    }
                   
                }
            }
          
        }
        private int _marginLeft = 0;
        public int ControlsMarginLeft
        {
            get { return _marginLeft; }
            set { _marginLeft = value; }
        }

        private int _marginTop = 0;
        public int ControlsMarginTop
        {
            get { return _marginTop; }
            set { _marginTop = value; }
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
