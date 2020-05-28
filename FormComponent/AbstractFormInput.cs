using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace FormComponent
{


    public abstract class AbstractFormInput : UserControl, IFormInput
    {
        private string _name;
        public string FieldName
        {
            get { return _name; }
            set { _name = value; }
        }


        public string ErrorMessage
        {
            get { return errorLabel.Text; }
            set { errorLabel.Text = value; }
        }

        protected Label errorLabel = new Label();

        public Point ErrorLabelLocation
        {
            get { return errorLabel.Location; }
            set { errorLabel.Location = value; }
        }

        public Size ErrorLabelSize
        {
            get { return errorLabel.Size; }
            set { errorLabel.Size = value; }
        }

        public Color ErrorLabelForeColor
        {
            get { return errorLabel.ForeColor; }
            set { errorLabel.ForeColor = value; }
        }

        public Color ErrorLabelBackColor
        {
            get { return errorLabel.BackColor; }
            set { errorLabel.BackColor = value; }
        }



        public string getName()
        {
            return _name;

        }

        private bool _hideErrorMessageOnChange = false;

        public bool HideErrorMessageOnChange
        {
            get { return _hideErrorMessageOnChange; }
            set { _hideErrorMessageOnChange = value; }
        }

        public void hideError(object sender, EventArgs e)
        {
            if (_hideErrorMessageOnChange)
            {
                errorLabel.Visible = false;
            }

        }

        public abstract bool isValid();


        public abstract string getValue();

        public abstract void clearField();


        public void setErrorSize(Size size)
        {
            errorLabel.Size = size;
            
        }

        public void setErrorPosition(Point point)
        {
            errorLabel.Location = point;
        }

        public abstract void setFieldHorizontalPosition(int horizontalPosition);

        public void setInputSize(Size size)
        {
            this.Size = size;
        }

        public Point getLocation()
        {
            return this.Location;
        }

        public void setLocation(Point point)
        {
            this.Location = point;
        }

        public void setSize(Size size)
        {
            this.Size = size;
        }

        public void setErrorColor(Color color)
        {
            errorLabel.ForeColor = color;
        }
    }
}
