using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormComponent
{
    public partial class FormTextInput : AbstractFormInput
    {

        private string _regex;
        public string RegularExpression
        {
            get { return _regex; }
            set { _regex = value; }
        }
        
        private TextBox field = new TextBox();

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

        public FormTextInput()
        {
            InitializeComponent();
        }

        public FormTextInput(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!this.Controls.Contains(field)) {
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
            if (_regex != null && _regex.Length > 0)
            {
                Regex r = new Regex(_regex);
                Match matcher = r.Match(field.Text);
                if (!matcher.Success)
                {
                    errorLabel.Visible = true; 
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        public override string getValue()
        {   
            return field.Text;
        }
    }

}
