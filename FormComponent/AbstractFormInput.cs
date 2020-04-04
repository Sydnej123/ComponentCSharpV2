using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace FormComponent
{
    public abstract class AbstractFormInput : UserControl, IFormInput
    {
        private string _name;
        public string FieldName {
            get { return _name; }
            set { _name = value; }
        }

        
        public string ErrorMessage
        {
            get { return errorLabel.Text; }
            set { errorLabel.Text = value; }
        }

        protected Label errorLabel = new Label();

        public Point ErrorLabelLocation {
            get { return errorLabel.Location;  }
            set { errorLabel.Location = value;  }
        }

        public Size ErrorLabelSize
        {
            get { return errorLabel.Size;  }
            set { errorLabel.Size = value; }
        }

       public Color ErrorLabelForeColor
       {
            get { return errorLabel.ForeColor;  }
            set { errorLabel.ForeColor = value;  }
       }
        
        public Color ErrorLabelBackColor
        {
            get { return errorLabel.BackColor; }
            set { errorLabel.BackColor = value;  }
        }

      

        public string getName()
        {
            return _name;
          
        }

        public abstract bool isValid();
        public abstract string getValue();
       
    }
}
