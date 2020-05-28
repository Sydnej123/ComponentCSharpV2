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

        public bool CheckDateBefore
        {
            get { return _dateCheckBefore;  }
            set { _dateCheckBefore = value;  }
        }

        public bool CheckDateAfter
        {
            get { return _dateCheckAfter; }
            set { _dateCheckAfter = value; }
        }
        public DateTime DateBefore{
            get {
                return _dateBefore;
            }
            set {
                 _dateBefore = value;
            }
        }

        public Point FieldLocation
        {
            get { return field.Location; }
            set { field.Location = value; }
        }

        public Size FieldSize
        {
            get { return field.Size; }
            set { field.Size = value; }
        }

        public Color FieldForeColor
        {
            get { return field.ForeColor; }
            set { field.ForeColor = value; }
        }

        public Color FieldBackColor
        {
            get { return field.BackColor; }
            set { field.BackColor = value; }
        }

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

        public override string getValue()
        {
            
            return field.Text;
        }
        public override void clearField()
        {
            field.Value = DateTime.Now;
        }
        public override void setFieldHorizontalPosition(int horizontalPosition)
        {
            this.Location = new Point(horizontalPosition, this.Location.Y);
        }
    }

}
