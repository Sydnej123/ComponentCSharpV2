using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormComponent
{
    public partial class FormDateInput : AbstractFormInput
    {
        private DateTime _dateBefore;
        private DateTime _dateAfter;
        private bool _dateCheckBefore;
        private bool _dateCheckAfter;

        /// <value>Gets and sets if date should be before desired</value>
        public bool CheckDateBefore
        {
            get { return _dateCheckBefore;  }
            set { _dateCheckBefore = value;  }
        }

        /// <value>Gets and sets if date should be after desired</value>
        public bool CheckDateAfter
        {
            get { return _dateCheckAfter; }
            set { _dateCheckAfter = value; }
        }
        /// <value>Gets and sets date before </value>
        public DateTime DateBefore{
            get {
                return _dateBefore;
            }
            set {
                 _dateBefore = value;
            }
        }
        /// <value>Gets and sets field location</value>
        public Point FieldLocation
        {
            get { return field.Location; }
            set { field.Location = value; }
        }
        /// <value>Gets and sets field size</value>
        public Size FieldSize
        {
            get { return field.Size; }
            set { field.Size = value; }
        }
        /// <value>Gets and sets field fore color</value>
        public Color FieldForeColor
        {
            get { return field.ForeColor; }
            set { field.ForeColor = value; }
        }
        /// <value>Gets and sets field back color</value>
        public Color FieldBackColor
        {
            get { return field.BackColor; }
            set { field.BackColor = value; }
        }
        /// <value>Gets and sets date after </value>
        public DateTime DateAfter
        {
            get
            {
                return _dateAfter;
            }
            set
            {
                _dateAfter = value;
            }
        }

        /// <summary>
        /// Resizing parent element if needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resizeElements(object sender, EventArgs e)
        {
            field.Width = this.Width;
            errorLabel.Width = this.Width;
            Form parent = Parent as Form;
            if (parent != null)
            {
                if (parent.Width < this.Location.X + this.Width)
                {
                    parent.Width += (this.Location.X + this.Width - parent.Width);
                }
            }
        }

        private DateTimePicker field = new DateTimePicker();
        /// <summary>
        ///  Default constructor.
        /// </summary>
        public FormDateInput()
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
            InitializeComponent();
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
            field.TextChanged += hideError;
            Form parent = Parent as Form;
            if (parent != null)
            {
                parent.revalidateGrid();
            }
        }
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="container">Container to which controll will be added</param>
        public FormDateInput(IContainer container)
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
            container.Add(this);
            InitializeComponent();
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
            field.TextChanged += hideError;
            Form parent = Parent as Form;
            if (parent != null)
            {
                parent.revalidateGrid();
            }
        }
        /// <summary>
        /// Painting component
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!this.Controls.Contains(field))
            {
                this.Controls.Add(field);
                this.Controls.Add(errorLabel);
               

            }

            Form parent = Parent as Form;
            if (parent != null)
            {
                parent.revalidateGrid();
            }
        }
        /// <summary>
        /// Check if field is valid
        /// </summary>
        /// <returns>Returns true if valid</returns>
        public override bool isValid()
        {
            bool isDateValid = true;
            if (_dateCheckBefore)
            {
                if (DateTime.Compare(field.Value, _dateBefore) > 0)
                {
                    
                    isDateValid = false;
                }
               
            }
            if (_dateCheckAfter)
            {
                if (DateTime.Compare(field.Value, _dateAfter) < 0)
                {
                    isDateValid = false;
                }

            }
            errorLabel.Visible = !isDateValid;
            return isDateValid;
        }
        /// <summary>
        /// Gets value of field
        /// </summary>
        /// <returns>Value of field</returns>
        public override string getValue()
        {
            
            return field.Text;
        }
        /// <summary>
        /// Set default value of field
        /// </summary>
        public override void clearField()
        {
            field.Value = DateTime.Now;
        }
       
    }

}
