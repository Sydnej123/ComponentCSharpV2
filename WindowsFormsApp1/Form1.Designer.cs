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
            FormComponent.FormComboBoxOption formComboBoxOption4 = new FormComponent.FormComboBoxOption();
            FormComponent.FormComboBoxOption formComboBoxOption5 = new FormComponent.FormComboBoxOption();
            FormComponent.FormComboBoxOption formComboBoxOption6 = new FormComponent.FormComboBoxOption();
            this.form2 = new FormComponent.Form(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formTextInput1 = new FormComponent.FormTextInput(this.components);
            this.formPasswordInput1 = new FormComponent.FormPasswordInput(this.components);
            this.formNumericField1 = new FormComponent.FormNumericField(this.components);
            this.formDateInput1 = new FormComponent.FormDateInput(this.components);
            this.formComboBox1 = new FormComponent.FormComboBox(this.components);
            this.formCheckboxInput1 = new FormComponent.FormCheckboxInput(this.components);
            this.form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2
            // 
            this.form2.AutoSize = true;
            this.form2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.form2.Controls.Add(this.button1);
            this.form2.Controls.Add(this.label7);
            this.form2.Controls.Add(this.label8);
            this.form2.Controls.Add(this.label6);
            this.form2.Controls.Add(this.label5);
            this.form2.Controls.Add(this.label4);
            this.form2.Controls.Add(this.label3);
            this.form2.Controls.Add(this.label2);
            this.form2.Controls.Add(this.label1);
            this.form2.Controls.Add(this.formTextInput1);
            this.form2.Controls.Add(this.formPasswordInput1);
            this.form2.Controls.Add(this.formNumericField1);
            this.form2.Controls.Add(this.formDateInput1);
            this.form2.Controls.Add(this.formComboBox1);
            this.form2.Controls.Add(this.formCheckboxInput1);
            this.form2.ControlsHoriziontalPosition = 150;
            this.form2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.form2.ErrorPosition = new System.Drawing.Point(0, 50);
            this.form2.ErrorSize = new System.Drawing.Size(200, 20);
            this.form2.FieldsSize = new System.Drawing.Size(300, 50);
            this.form2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.form2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.form2.Location = new System.Drawing.Point(1, 1);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(477, 660);
            this.form2.TabIndex = 0;
            this.form2.Load += new System.EventHandler(this.form2_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(150, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Urodziny";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(149, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 35);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rejestracja";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wiek";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Akceptuje regulamin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formTextInput1
            // 
            this.formTextInput1.ErrorLabelBackColor = System.Drawing.SystemColors.HotTrack;
            this.formTextInput1.ErrorLabelForeColor = System.Drawing.Color.DarkRed;
            this.formTextInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formTextInput1.ErrorLabelSize = new System.Drawing.Size(300, 15);
            this.formTextInput1.ErrorMessage = "Błędny login";
            this.formTextInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput1.FieldForeColor = System.Drawing.Color.Empty;
            this.formTextInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput1.FieldName = null;
            this.formTextInput1.FieldSize = new System.Drawing.Size(300, 29);
            this.formTextInput1.IsRequired = true;
            this.formTextInput1.Location = new System.Drawing.Point(150, 106);
            this.formTextInput1.MaxLength = 3;
            this.formTextInput1.Name = "formTextInput1";
            this.formTextInput1.Placeholder = "login";
            this.formTextInput1.RegularExpression = "abecalo";
            this.formTextInput1.Size = new System.Drawing.Size(300, 79);
            this.formTextInput1.TabIndex = 5;
            // 
            // formPasswordInput1
            // 
            this.formPasswordInput1.ErrorLabelBackColor = System.Drawing.SystemColors.HotTrack;
            this.formPasswordInput1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formPasswordInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formPasswordInput1.ErrorLabelSize = new System.Drawing.Size(300, 15);
            this.formPasswordInput1.ErrorMessage = "";
            this.formPasswordInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formPasswordInput1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formPasswordInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formPasswordInput1.FieldName = null;
            this.formPasswordInput1.FieldSize = new System.Drawing.Size(300, 29);
            this.formPasswordInput1.Location = new System.Drawing.Point(150, 191);
            this.formPasswordInput1.MaxLength = 8;
            this.formPasswordInput1.Name = "formPasswordInput1";
            this.formPasswordInput1.Placeholder = "hasło";
            this.formPasswordInput1.RegularExpression = null;
            this.formPasswordInput1.Size = new System.Drawing.Size(300, 50);
            this.formPasswordInput1.TabIndex = 4;
            // 
            // formNumericField1
            // 
            this.formNumericField1.DecimalPlaces = 0;
            this.formNumericField1.ErrorLabelBackColor = System.Drawing.SystemColors.HotTrack;
            this.formNumericField1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formNumericField1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formNumericField1.ErrorLabelSize = new System.Drawing.Size(300, 15);
            this.formNumericField1.ErrorMessage = "";
            this.formNumericField1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formNumericField1.FieldForeColor = System.Drawing.Color.Empty;
            this.formNumericField1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formNumericField1.FieldName = null;
            this.formNumericField1.FieldSize = new System.Drawing.Size(300, 29);
            this.formNumericField1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formNumericField1.Location = new System.Drawing.Point(150, 267);
            this.formNumericField1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.formNumericField1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.formNumericField1.Name = "formNumericField1";
            this.formNumericField1.Size = new System.Drawing.Size(300, 50);
            this.formNumericField1.TabIndex = 3;
            this.formNumericField1.ThousandsSeparator = false;
            // 
            // formDateInput1
            // 
            this.formDateInput1.CheckDateAfter = false;
            this.formDateInput1.CheckDateBefore = false;
            this.formDateInput1.DateAfter = new System.DateTime(((long)(0)));
            this.formDateInput1.DateBefore = new System.DateTime(((long)(0)));
            this.formDateInput1.ErrorLabelBackColor = System.Drawing.SystemColors.HotTrack;
            this.formDateInput1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formDateInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formDateInput1.ErrorLabelSize = new System.Drawing.Size(300, 15);
            this.formDateInput1.ErrorMessage = "";
            this.formDateInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formDateInput1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formDateInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formDateInput1.FieldName = null;
            this.formDateInput1.FieldSize = new System.Drawing.Size(300, 29);
            this.formDateInput1.Location = new System.Drawing.Point(150, 352);
            this.formDateInput1.Name = "formDateInput1";
            this.formDateInput1.Size = new System.Drawing.Size(300, 50);
            this.formDateInput1.TabIndex = 2;
            // 
            // formComboBox1
            // 
            this.formComboBox1.ErrorLabelBackColor = System.Drawing.SystemColors.HotTrack;
            this.formComboBox1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formComboBox1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formComboBox1.ErrorLabelSize = new System.Drawing.Size(300, 15);
            this.formComboBox1.ErrorMessage = "";
            this.formComboBox1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formComboBox1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formComboBox1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formComboBox1.FieldName = null;
            this.formComboBox1.FieldSize = new System.Drawing.Size(300, 24);
            this.formComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.formComboBox1.IsRequired = true;
            formComboBoxOption4.Text = "Mężczyzna";
            formComboBoxOption4.Value = "m";
            formComboBoxOption5.Text = "Kobieta";
            formComboBoxOption5.Value = "k";
            formComboBoxOption6.Text = "Nieokreślona";
            formComboBoxOption6.Value = "n";
            this.formComboBox1.Items = new FormComponent.FormComboBoxOption[] {
        formComboBoxOption4,
        formComboBoxOption5,
        formComboBoxOption6};
            this.formComboBox1.Location = new System.Drawing.Point(150, 428);
            this.formComboBox1.Name = "formComboBox1";
            this.formComboBox1.Size = new System.Drawing.Size(300, 50);
            this.formComboBox1.TabIndex = 1;
            // 
            // formCheckboxInput1
            // 
            this.formCheckboxInput1.ErrorLabelBackColor = System.Drawing.SystemColors.HotTrack;
            this.formCheckboxInput1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formCheckboxInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formCheckboxInput1.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formCheckboxInput1.ErrorMessage = "";
            this.formCheckboxInput1.FieldBackColor = System.Drawing.SystemColors.HotTrack;
            this.formCheckboxInput1.FieldForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formCheckboxInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formCheckboxInput1.FieldName = null;
            this.formCheckboxInput1.FieldSize = new System.Drawing.Size(200, 30);
            this.formCheckboxInput1.Location = new System.Drawing.Point(150, 530);
            this.formCheckboxInput1.Name = "formCheckboxInput1";
            this.formCheckboxInput1.Required = false;
            this.formCheckboxInput1.Size = new System.Drawing.Size(300, 50);
            this.formCheckboxInput1.TabIndex = 0;
            this.formCheckboxInput1.Load += new System.EventHandler(this.formCheckboxInput1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 639);
            this.Controls.Add(this.form2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.form2.ResumeLayout(false);
            this.form2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormComponent.Form form2;
        private System.Windows.Forms.Label label1;
        private FormComponent.FormTextInput formTextInput1;
        private FormComponent.FormPasswordInput formPasswordInput1;
        private FormComponent.FormNumericField formNumericField1;
        private FormComponent.FormDateInput formDateInput1;
        private FormComponent.FormComboBox formComboBox1;
        private FormComponent.FormCheckboxInput formCheckboxInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

