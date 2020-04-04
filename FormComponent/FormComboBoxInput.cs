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
        private bool _isRequired;
       
        
        public Object[] Items
        {
            get {
                Object[] temp = new object[field.Items.Count];
                int i = 0;
                foreach(Object o in field.Items) {
                    temp[i] = o;
                    i++;
                }
                return temp; 
            }
            set {
                field.Items.Clear();
                foreach (Object o in value)
                {
                    field.Items.Add(o);
                  
                }
            }
        }
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
        public FormComboBox()
        {
            InitializeComponent();
        }

        public FormComboBox(IContainer container)
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
            if (_isRequired)
            {
                if (field.SelectedItem.ToString().Length > 0)
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
            return field.SelectedItem.ToString();
        }
    }


}
