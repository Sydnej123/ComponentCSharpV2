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
    /// <summary>
    ///  Represents password input control for Form component.
    /// </summary>
    public partial class FormPasswordInput : AbstractFormInput
    {
        private string _regex;
        private TextBox field = new TextBox();

        /// <value>Gets and sets regular expression</value>
        public string RegularExpression
        {
            get { return _regex; }
            set { _regex = value; }
        }
        /// <value>Gets and sets if field max length</value>
        public int MaxLength
        {
            get { return this.field.MaxLength; }
            set { this.field.MaxLength = value; }
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
        /// <value>Gets and sets field back color</value
        public Color FieldBackColor
        {
            get { return field.BackColor; }
            set { field.BackColor = value; }
        }

        private bool _isRequired;
        /// <value>Gets and sets if field value is required</value>
        public bool IsRequired
        {
            get { return _isRequired; }
            set { _isRequired = value; }
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


        private String _placeholderText;
        /// <value>Gets and sets placeholder text</value>
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
        /// <summary>
        /// Decides if placeholder should be seen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Default constructor
        /// </summary>
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
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="container">Contrainer to which control will be added</param>
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
        /// <summary>
        /// Gets value of field
        /// </summary>
        /// <returns>Value of field</returns>
        public override string getValue()
        {
            return field.Text;
        }
        /// <summary>
        /// Set default value of field
        /// </summary>
        public override void clearField()
        {
            field.Clear();
        }
     

    }
}
