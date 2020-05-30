using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace FormComponent
{
    /// <summary>
    /// Class designed for Form component. It contains numeric field and error label.
    /// </summary>
    public partial class FormNumericField : AbstractFormInput
    {
        private NumericUpDown field = new NumericUpDown();
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

        private Color _foreColor;
        /// <value>Gets and sets field fore color</value>
        public Color FieldForeColor
        {
            get { return _foreColor; }
            set
            {
                _foreColor = value;
            }
        }
        /// <value>Gets and sets field back color</value>
        public Color FieldBackColor
        {
            get { return field.BackColor; }
            set { field.BackColor = value; }
        }
        /// <value>Gets and sets field decimal places</value>
        public int DecimalPlaces
        {
            get { return field.DecimalPlaces;  }
            set { field.DecimalPlaces = value; }
        }
        /// <value>Gets and sets field increment step</value>
        public decimal Increment
        {
            get { return field.Increment; }
            set { field.Increment = value; }
        }

        /// <value>Gets and sets field maximum value</value>
        public decimal Maximum
        {
            get { return field.Maximum; }
            set { field.Maximum = value; }
        }
        /// <value>Gets and sets minimum valuer</value>
        public decimal Minimum
        {
            get { return field.Minimum; }
            set { field.Minimum= value; }
        }
        /// <value>Gets and sets if thousandsseparator should be visible</value>
        public Boolean ThousandsSeparator
        {
            get { return field.ThousandsSeparator;  }
            set { field.ThousandsSeparator = value;  }
        }

        /// <summary>
        /// Resize parent element if neccessary.
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
        /// <summary>
        /// Default constructor
        /// </summary>
        public FormNumericField()
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
        /// Default constructor
        /// </summary>
        /// <param name="container">Contrainer to which control will be added</param>
        public FormNumericField(IContainer container)
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
            return true;
        }
        /// <summary>
        /// Gets value of field
        /// </summary>
        /// <returns>Value of field</returns>
        public override string getValue()
        {
            return field.Value.ToString();
        }
        /// <summary>
        /// Set default value of field
        /// </summary>
        public override void clearField()
        {
            field.Value = field.Minimum;
        }
      
    }
}
