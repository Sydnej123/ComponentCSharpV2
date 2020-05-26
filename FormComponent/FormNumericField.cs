using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace FormComponent
{
    public partial class FormNumericField : AbstractFormInput
    {
        private NumericUpDown field = new NumericUpDown();
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

        private Color _foreColor;

        public Color FieldForeColor
        {
            get { return _foreColor; }
            set
            {
                _foreColor = value;
            }
        }

        public Color FieldBackColor
        {
            get { return field.BackColor; }
            set { field.BackColor = value; }
        }

        public int DecimalPlaces
        {
            get { return field.DecimalPlaces;  }
            set { field.DecimalPlaces = value; }
        }

       public decimal Increment
        {
            get { return field.Increment; }
            set { field.Increment = value; }
        }

        public decimal Maximum
        {
            get { return field.Maximum; }
            set { field.Maximum = value; }
        }

        public decimal Minimum
        {
            get { return field.Minimum; }
            set { field.Minimum= value; }
        }

        public Boolean ThousandsSeparator
        {
            get { return field.ThousandsSeparator;  }
            set { field.ThousandsSeparator = value;  }
        }

        private void resizeElements(object sender, EventArgs e)
        {
            field.Width = this.Width;
            errorLabel.Width = this.Width;
        }

        public FormNumericField()
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
            InitializeComponent();
        }

        public FormNumericField(IContainer container)
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
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
            return true;
        }
        public override string getValue()
        {
            return field.Value.ToString();
        }
        public override void clearField()
        {
            field.Value = field.Minimum;
        }
        public override void setFieldHorizontalPosition(int horizontalPosition)
        {
            this.Location = new Point(horizontalPosition, this.Location.Y);
        }
    }
}
