using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace FormComponent
{

    /// <summary>
    ///   Abstract base class for all FormComponent input types.
    /// </summary>


    public abstract class AbstractFormInput : UserControl, IFormInput
    {
        private string _name;
        /// <value>Gets and sets input name</value>;
        public string FieldName
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <value>Gets and sets error message</value>
        public string ErrorMessage
        {
            get { return errorLabel.Text; }
            set { errorLabel.Text = value; }
        }

        protected Label errorLabel = new Label();

        /// <value>Gets and sets error label location</value>
        public Point ErrorLabelLocation
        {
            get { return errorLabel.Location; }
            set { errorLabel.Location = value; }
        }

        /// <value>Gets and sets error label size</value>
        public Size ErrorLabelSize
        {
            get { return errorLabel.Size; }
            set { errorLabel.Size = value; }
        }

        /// <value>Gets and sets error label fore color</value>
        public Color ErrorLabelForeColor
        {
            get { return errorLabel.ForeColor; }
            set { errorLabel.ForeColor = value; }
        }

        /// <value>Gets and sets error label back color</value>
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

        /// <value>Gets and sets if error should be hidden after text changed</value>
        public bool HideErrorMessageOnChange
        {
            get { return _hideErrorMessageOnChange; }
            set { _hideErrorMessageOnChange = value; }
        }

        /// <summary>
        /// Decides if error should be hidden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets error size
        /// </summary>
        /// <param name="size">Size of error</param>
        public void setErrorSize(Size size)
        {
            errorLabel.Size = size;
            
        }

        /// <summary>
        /// Sets error position
        /// </summary>
        /// <param name="point">Desired location</param>
        public void setErrorPosition(Point point)
        {
            errorLabel.Location = point;
        }


        /// <summary>
        /// Sets input field size
        /// </summary>
        /// <param name="size">Desired size of field</param>
        public void setInputSize(Size size)
        {
            this.Size = size;
        }
        /// <summary>
        /// Gets current location of field
        /// </summary>
        /// <returns>Location of field</returns>
        public Point getLocation()
        {
            return this.Location;
        }

        /// <summary>
        /// Sets current location of field
        /// </summary>
        /// <param name="point">Desired location</param>
        public void setLocation(Point point)
        {
            this.Location = point;
        }

        /// <summary>
        /// Sets desired size of field
        /// </summary>
        /// <param name="size">Desired size</param>
        public void setSize(Size size)
        {
            this.Size = size;
        }

        /// <summary>
        /// Sets color of error label
        /// </summary>
        /// <param name="color">Desired color of error label</param>
        public void setErrorColor(Color color)
        {
            errorLabel.ForeColor = color;
        }
    }
}
