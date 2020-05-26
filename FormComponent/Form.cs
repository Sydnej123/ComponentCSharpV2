using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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

        private int _controlsHorizontalPosition;
        public int ControlsHoriziontalPosition
        {
            get { return _controlsHorizontalPosition; }
            set {
                _controlsHorizontalPosition = value;
                foreach (Control c in Controls)
                {
                    IFormInput obj = c as IFormInput;
                    if (obj != null)
                    {
                        obj.setFieldHorizontalPosition(value);
                    }
                }
            }
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


        public Form()
        {
            InitializeComponent();
        }

        public Form(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private bool validateForm()
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

        public String getData() {
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
