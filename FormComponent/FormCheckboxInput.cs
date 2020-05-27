using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormComponent
{
    public partial class FormCheckboxInput : AbstractFormInput
    {
        private CheckBox field = new CheckBox();
        public FormCheckboxInput()
        {
            errorLabel.Visible = false;
            InitializeComponent();
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
            field.TextChanged += hideError;
        }

        private bool _isRequired;
        public bool Required
        {
            get { return _isRequired; }
            set { _isRequired = value; }
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
        public FormCheckboxInput(IContainer container)
        {
            errorLabel.Visible = false;
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
            if (_isRequired && !field.Checked)
            {
                errorLabel.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string getValue()
        {
            return field.Checked.ToString();
        }
        public override void clearField()
        {
            field.Checked = false;
        }

        public override void setFieldHorizontalPosition(int horizontalPosition)
        {
            this.Location = new Point(horizontalPosition, this.Location.Y);
        }
    }

}
