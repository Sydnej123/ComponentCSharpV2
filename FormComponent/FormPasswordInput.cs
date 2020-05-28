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

        private bool _isRequired;
        public bool IsRequired
        {
            get { return _isRequired; }
            set { _isRequired = value; }
        }
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
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
            field.TextChanged += hideError;
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
            this.Size = new System.Drawing.Size(200, 50);
            field.Size = new System.Drawing.Size(200, 30);
            errorLabel.Size = new System.Drawing.Size(200, 15);
            errorLabel.Location = new System.Drawing.Point(0, 35);
            field.TextChanged += hideError;
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
                    errorLabel.Visible = false;
                    return true;
                }
            }
            else if (_isRequired && field.Text.Length < 0)
            {
                errorLabel.Visible = true;
                return false;
            }
            else if (field.Text.Equals(_placeholderText))
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
