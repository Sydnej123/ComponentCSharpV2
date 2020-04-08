using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

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
