using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormComponent
{
    /// <summary>
    /// Class designed for Form component. It contains checkbox and error label.
    /// </summary>
    public partial class FormCheckboxInput : AbstractFormInput
    {
        private CheckBox field = new CheckBox();
        /// <summary>
        /// Default constructor
        /// </summary>
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
        /// <value>Gets and sets if field value is required</value>
        public bool Required
        {
            get { return _isRequired; }
            set { _isRequired = value; }
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
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="container">Contrainer to which control will be added</param>
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
            if (_isRequired && !field.Checked)
            {
                errorLabel.Visible = true;
                return false;
            }
            else
            {
                errorLabel.Visible = false;
                return true;
            }
        }

        /// <summary>
        /// Gets value of field
        /// </summary>
        /// <returns>Value of field</returns>
        public override string getValue()
        {
            return field.Checked.ToString();
        }
        /// <summary>
        /// Set default value of field
        /// </summary>
        public override void clearField()
        {
            field.Checked = false;
        }
    }

}
