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
            InitializeComponent();
        }

        private bool _isRequired;
        public bool Required
        {
            get { return _isRequired; }
            set { _isRequired = value;  }
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
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!this.Controls.Contains(field))
            {
                this.Controls.Add(field);
                this.Controls.Add(errorLabel);
                this.Size = new System.Drawing.Size(200, 50);
                field.Size = new System.Drawing.Size(200, 30);
                errorLabel.Size = new System.Drawing.Size(200, 15);
                errorLabel.Location = new System.Drawing.Point(0, 35);

            }
        }
        public override bool isValid()
        {
            if (_isRequired && !field.Checked)
            {
                errorLabel.Visible = true;
                return false;
            }
            else {
                return true;
            }
        }

        public override string getValue()
        {
            return field.Checked.ToString();
        }
    }


}
