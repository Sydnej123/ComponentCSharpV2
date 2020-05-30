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
    /// Class represents combobox for Form controller.
    /// </summary>
    public partial class FormComboBox : AbstractFormInput
    {
        private ComboBox field = new ComboBox();


        /// <value>Gets and sets items of type FormComboBoxOption for Form component</value>
        public FormComboBoxOption[] Items
        {
            get {
                FormComboBoxOption[] temp = new FormComboBoxOption[field.Items.Count];
                int i = 0;
                foreach(FormComboBoxOption o in field.Items) {
                    temp[i] = o;
                    i++;
                }
                return temp; 
            }
            set {
                field.Items.Clear();
                foreach (FormComboBoxOption o in value)
                {
                    field.Items.Add(o);
                  
                }
            }
        }
        private bool _isRequired;
        /// <value>Gets and sets if field is required</value>
        public bool IsRequired
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
        /// Resize elements if neccesary.
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
        public FormComboBox()
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
            InitializeComponent();
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
            Form parent = Parent as Form;
            if (parent != null)
            {
                parent.revalidateGrid();
            }
        }
        /// <summary>
        /// Default constructor if component is added to container
        /// </summary>
        /// <param name="container">Contailer</param>
        public FormComboBox(IContainer container)
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
            container.Add(this);
            InitializeComponent();
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
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
        /// Check if field have valid value
        /// </summary>
        /// <returns>If field is valid</returns>
        public override bool isValid()
        {
            if (_isRequired)
            {
                if (field.SelectedItem != null)
                {
                    errorLabel.Visible = false;
                    return true;
                }
                else
                {
                    errorLabel.Visible = true;
                    return false;
                }
            }else
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
            if(((FormComboBoxOption)field.SelectedItem) != null)
            {
                return ((FormComboBoxOption)field.SelectedItem).Value;
            }
            else
            {
                return "";
            }
           
        }
        /// <summary>
        /// Set default value of field
        /// </summary>
        public override void clearField()
        {
            field.SelectedIndex = 0;
        }
       
    }


}
