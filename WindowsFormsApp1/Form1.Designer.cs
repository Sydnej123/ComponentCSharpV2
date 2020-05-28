namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            FormComponent.FormComboBoxOption formComboBoxOption1 = new FormComponent.FormComboBoxOption();
            FormComponent.FormComboBoxOption formComboBoxOption2 = new FormComponent.FormComboBoxOption();
            this.form2 = new FormComponent.Form(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.formCheckboxInput1 = new FormComponent.FormCheckboxInput(this.components);
            this.formComboBox1 = new FormComponent.FormComboBox(this.components);
            this.formNumericField1 = new FormComponent.FormNumericField(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formDateInput1 = new FormComponent.FormDateInput(this.components);
            this.formTextInput2 = new FormComponent.FormTextInput(this.components);
            this.formPasswordInput1 = new FormComponent.FormPasswordInput(this.components);
            this.formTextInput1 = new FormComponent.FormTextInput(this.components);
            this.form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2
            // 
            this.form2.BackColor = System.Drawing.Color.DodgerBlue;
            this.form2.ControlGrid = true;
            this.form2.Controls.Add(this.label9);
            this.form2.Controls.Add(this.textBox1);
            this.form2.Controls.Add(this.button1);
            this.form2.Controls.Add(this.label8);
            this.form2.Controls.Add(this.formCheckboxInput1);
            this.form2.Controls.Add(this.formComboBox1);
            this.form2.Controls.Add(this.formNumericField1);
            this.form2.Controls.Add(this.label7);
            this.form2.Controls.Add(this.label6);
            this.form2.Controls.Add(this.label5);
            this.form2.Controls.Add(this.label4);
            this.form2.Controls.Add(this.label3);
            this.form2.Controls.Add(this.label2);
            this.form2.Controls.Add(this.label1);
            this.form2.Controls.Add(this.formDateInput1);
            this.form2.Controls.Add(this.formTextInput2);
            this.form2.Controls.Add(this.formPasswordInput1);
            this.form2.Controls.Add(this.formTextInput1);
            this.form2.ControlsMarginBottom = 5;
            this.form2.ControlsMarginLeft = 300;
            this.form2.ControlsMarginRight = 200;
            this.form2.ControlsMarginTop = 5;
            this.form2.ControlsSizeFillToParent = true;
            this.form2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form2.ErrorPosition = new System.Drawing.Point(0, 28);
            this.form2.ErrorSize = new System.Drawing.Size(200, 24);
            this.form2.FieldsSize = new System.Drawing.Size(312, 60);
            this.form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.form2.Location = new System.Drawing.Point(0, 0);
            this.form2.MinimumSize = new System.Drawing.Size(800, 600);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(812, 749);
            this.form2.TabIndex = 0;
            this.form2.Load += new System.EventHandler(this.form2_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(120, 689);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dane";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(300, 689);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(300, 617);
            this.button1.MinimumSize = new System.Drawing.Size(300, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(317, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Akceptuje regulamin";
            // 
            // formCheckboxInput1
            // 
            this.formCheckboxInput1.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formCheckboxInput1.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formCheckboxInput1.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formCheckboxInput1.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formCheckboxInput1.ErrorMessage = "*Wymagane pole";
            this.formCheckboxInput1.FieldBackColor = System.Drawing.Color.DodgerBlue;
            this.formCheckboxInput1.FieldForeColor = System.Drawing.SystemColors.ControlText;
            this.formCheckboxInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formCheckboxInput1.FieldName = "rulesAccepted";
            this.formCheckboxInput1.FieldSize = new System.Drawing.Size(200, 30);
            this.formCheckboxInput1.HideErrorMessageOnChange = true;
            this.formCheckboxInput1.Location = new System.Drawing.Point(300, 551);
            this.formCheckboxInput1.Name = "formCheckboxInput1";
            this.formCheckboxInput1.Required = true;
            this.formCheckboxInput1.Size = new System.Drawing.Size(312, 60);
            this.formCheckboxInput1.TabIndex = 13;
            // 
            // formComboBox1
            // 
            this.formComboBox1.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formComboBox1.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formComboBox1.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formComboBox1.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formComboBox1.ErrorMessage = "*Wymagane pole";
            this.formComboBox1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formComboBox1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formComboBox1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formComboBox1.FieldName = "sex";
            this.formComboBox1.FieldSize = new System.Drawing.Size(312, 32);
            this.formComboBox1.HideErrorMessageOnChange = false;
            this.formComboBox1.IsRequired = true;
            formComboBoxOption1.Text = "Mężczyzna";
            formComboBoxOption1.Value = "m";
            formComboBoxOption2.Text = "Kobieta";
            formComboBoxOption2.Value = "k";
            this.formComboBox1.Items = new FormComponent.FormComboBoxOption[] {
        formComboBoxOption1,
        formComboBoxOption2};
            this.formComboBox1.Location = new System.Drawing.Point(300, 481);
            this.formComboBox1.Name = "formComboBox1";
            this.formComboBox1.Size = new System.Drawing.Size(312, 60);
            this.formComboBox1.TabIndex = 12;
            // 
            // formNumericField1
            // 
            this.formNumericField1.DecimalPlaces = 0;
            this.formNumericField1.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formNumericField1.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formNumericField1.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formNumericField1.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formNumericField1.ErrorMessage = "";
            this.formNumericField1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formNumericField1.FieldForeColor = System.Drawing.Color.Empty;
            this.formNumericField1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formNumericField1.FieldName = "age";
            this.formNumericField1.FieldSize = new System.Drawing.Size(312, 29);
            this.formNumericField1.HideErrorMessageOnChange = false;
            this.formNumericField1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formNumericField1.Location = new System.Drawing.Point(300, 411);
            this.formNumericField1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.formNumericField1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formNumericField1.Name = "formNumericField1";
            this.formNumericField1.Size = new System.Drawing.Size(312, 60);
            this.formNumericField1.TabIndex = 11;
            this.formNumericField1.ThousandsSeparator = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(120, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(120, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(120, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(120, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(120, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(120, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(812, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rejestracja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formDateInput1
            // 
            this.formDateInput1.CheckDateAfter = false;
            this.formDateInput1.CheckDateBefore = false;
            this.formDateInput1.DateAfter = new System.DateTime(((long)(0)));
            this.formDateInput1.DateBefore = new System.DateTime(((long)(0)));
            this.formDateInput1.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formDateInput1.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formDateInput1.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formDateInput1.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formDateInput1.ErrorMessage = "";
            this.formDateInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formDateInput1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formDateInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formDateInput1.FieldName = "date";
            this.formDateInput1.FieldSize = new System.Drawing.Size(312, 29);
            this.formDateInput1.HideErrorMessageOnChange = false;
            this.formDateInput1.Location = new System.Drawing.Point(300, 341);
            this.formDateInput1.Name = "formDateInput1";
            this.formDateInput1.Size = new System.Drawing.Size(312, 60);
            this.formDateInput1.TabIndex = 3;
            // 
            // formTextInput2
            // 
            this.formTextInput2.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formTextInput2.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formTextInput2.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formTextInput2.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formTextInput2.ErrorMessage = "Błędny email";
            this.formTextInput2.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput2.FieldForeColor = System.Drawing.Color.Empty;
            this.formTextInput2.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput2.FieldName = "email";
            this.formTextInput2.FieldSize = new System.Drawing.Size(312, 29);
            this.formTextInput2.HideErrorMessageOnChange = true;
            this.formTextInput2.IsRequired = true;
            this.formTextInput2.Location = new System.Drawing.Point(300, 271);
            this.formTextInput2.MaxLength = 32767;
            this.formTextInput2.Name = "formTextInput2";
            this.formTextInput2.Placeholder = "email";
            this.formTextInput2.RegularExpression = "\\A(?:[a-z0-9!#$%&\'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](" +
    "?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z";
            this.formTextInput2.Size = new System.Drawing.Size(312, 60);
            this.formTextInput2.TabIndex = 2;
            // 
            // formPasswordInput1
            // 
            this.formPasswordInput1.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formPasswordInput1.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formPasswordInput1.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formPasswordInput1.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formPasswordInput1.ErrorMessage = "Błędne hasło";
            this.formPasswordInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formPasswordInput1.FieldForeColor = System.Drawing.Color.Empty;
            this.formPasswordInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formPasswordInput1.FieldName = "password";
            this.formPasswordInput1.FieldSize = new System.Drawing.Size(312, 29);
            this.formPasswordInput1.HideErrorMessageOnChange = false;
            this.formPasswordInput1.IsRequired = true;
            this.formPasswordInput1.Location = new System.Drawing.Point(300, 201);
            this.formPasswordInput1.MaxLength = 32767;
            this.formPasswordInput1.Name = "formPasswordInput1";
            this.formPasswordInput1.Placeholder = "hasło";
            this.formPasswordInput1.RegularExpression = "";
            this.formPasswordInput1.Size = new System.Drawing.Size(312, 60);
            this.formPasswordInput1.TabIndex = 1;
            // 
            // formTextInput1
            // 
            this.formTextInput1.ErrorLabelBackColor = System.Drawing.Color.DodgerBlue;
            this.formTextInput1.ErrorLabelForeColor = System.Drawing.Color.Red;
            this.formTextInput1.ErrorLabelLocation = new System.Drawing.Point(0, 28);
            this.formTextInput1.ErrorLabelSize = new System.Drawing.Size(200, 24);
            this.formTextInput1.ErrorMessage = "Niedozwolony login";
            this.formTextInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput1.FieldForeColor = System.Drawing.Color.Empty;
            this.formTextInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput1.FieldName = "login";
            this.formTextInput1.FieldSize = new System.Drawing.Size(312, 29);
            this.formTextInput1.HideErrorMessageOnChange = true;
            this.formTextInput1.IsRequired = false;
            this.formTextInput1.Location = new System.Drawing.Point(300, 131);
            this.formTextInput1.MaxLength = 32767;
            this.formTextInput1.Name = "formTextInput1";
            this.formTextInput1.Placeholder = "login";
            this.formTextInput1.RegularExpression = "";
            this.formTextInput1.Size = new System.Drawing.Size(312, 60);
            this.formTextInput1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(812, 749);
            this.Controls.Add(this.form2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form2.ResumeLayout(false);
            this.form2.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private FormComponent.Form form2;
        private System.Windows.Forms.Label label1;
        private FormComponent.FormDateInput formDateInput1;
        private FormComponent.FormTextInput formTextInput2;
        private FormComponent.FormPasswordInput formPasswordInput1;
        private FormComponent.FormTextInput formTextInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private FormComponent.FormCheckboxInput formCheckboxInput1;
        private FormComponent.FormComboBox formComboBox1;
        private FormComponent.FormNumericField formNumericField1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}

