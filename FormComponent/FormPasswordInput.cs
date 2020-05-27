using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using System.Drawing;

namespace FormComponent
{
    
    public partial class FormPasswordInput : AbstractFormInput
    {
        private string _regex;
        private TextBox field = new TextBox();

        public string RegularExpression
        {
            get { return _regex; }
            set { _regex = value; }
        }

        public int MaxLength
        {
            get { return this.field.MaxLength; }
            set { this.field.MaxLength = value; }
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
        private void resizeElements(object sender, EventArgs e)
        {
            field.Width = this.Width;
            errorLabel.Width = this.Width;
        }


        private String _placeholderText;

        public String Placeholder
        {
            get { return this._placeholderText; }
            set
            {
                this._placeholderText = value;
                this.field.Text = value;
                if (value != string.Empty)
                {
                    this.field.ForeColor = Color.Gray;
                }

            }
        }
        private void showPlaceholder(object sender, EventArgs e)
        {
            if (this.field.Text == string.Empty)
            {
                this.field.ForeColor = Color.Gray;
                this.field.Text = _placeholderText;
                this.field.PasswordChar = '\0';
            }
            else
            {
                this.field.PasswordChar = '*';
                this.field.ForeColor = this._foreColor;
            }
        }
        private void hidePlaceholder(object sender, EventArgs e)
        {
            if (this.field.Text == _placeholderText)
            {
                this.field.PasswordChar = '*';
                this.field.ForeColor = this._foreColor;
                this.field.Text = "";
            }

        }
        public FormPasswordInput()
        {
            this.field.Text = _placeholderText;
            this.field.GotFocus += hidePlaceholder;
            this.field.LostFocus += showPlaceholder;
            this.Resize += resizeElements;
            errorLabel.Visible = false;
            InitializeComponent();
        }

        public FormPasswordInput(IContainer container)
        {
            this.field.Text = _placeholderText;
            this.field.GotFocus += hidePlaceholder;
            this.field.LostFocus += showPlaceholder;
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
            if (_regex != null &&_regex.Length > 0)
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
        public override void clearField()
        {
            field.Clear();
        }
        public override void setFieldHorizontalPosition(int horizontalPosition)
        {
            this.Location = new Point(horizontalPosition, this.Location.Y);
        }

    }
}
