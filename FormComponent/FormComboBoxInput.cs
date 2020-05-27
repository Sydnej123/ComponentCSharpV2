using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormComponent
{
    public partial class FormComboBox : AbstractFormInput
    {
        private ComboBox field = new ComboBox();
      
       
        
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
        public bool IsRequired
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

        private void resizeElements(object sender, EventArgs e)
        {
            field.Width = this.Width;
            errorLabel.Width = this.Width;
        }

        public FormComboBox()
        {
            errorLabel.Visible = false;
            this.Resize += resizeElements;
            InitializeComponent();
        }

        public FormComboBox(IContainer container)
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
            if (_isRequired)
            {
                if (field.SelectedItem != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else
            {
                return true;
            }
        }

        public override string getValue()
        {
            return ((FormComboBoxOption)field.SelectedItem).Value;
        }
        public override void clearField()
        {
            field.SelectedIndex = 0;
        }
        public override void setFieldHorizontalPosition(int horizontalPosition)
        {
            this.Location = new Point(horizontalPosition, this.Location.Y);
        }
    }


}
