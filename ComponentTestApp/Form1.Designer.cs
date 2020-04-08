namespace ComponentTestApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.form2 = new FormComponent.Form(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formTextInput4 = new FormComponent.FormTextInput(this.components);
            this.formTextInput3 = new FormComponent.FormTextInput(this.components);
            this.formTextInput2 = new FormComponent.FormTextInput(this.components);
            this.formTextInput1 = new FormComponent.FormTextInput(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 1;
            // 
            // form2
            // 
            this.form2.Controls.Add(this.textBox1);
            this.form2.Controls.Add(this.label5);
            this.form2.Controls.Add(this.button2);
            this.form2.Controls.Add(this.button1);
            this.form2.Controls.Add(this.label4);
            this.form2.Controls.Add(this.label3);
            this.form2.Controls.Add(this.label2);
            this.form2.Controls.Add(this.label1);
            this.form2.Controls.Add(this.formTextInput4);
            this.form2.Controls.Add(this.formTextInput3);
            this.form2.Controls.Add(this.formTextInput2);
            this.form2.Controls.Add(this.formTextInput1);
            this.form2.Location = new System.Drawing.Point(228, 53);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(328, 288);
            this.form2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Wyczyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numer telefonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formTextInput4
            // 
            this.formTextInput4.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formTextInput4.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formTextInput4.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formTextInput4.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formTextInput4.ErrorMessage = "";
            this.formTextInput4.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput4.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formTextInput4.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput4.FieldName = "email";
            this.formTextInput4.FieldSize = new System.Drawing.Size(200, 20);
            this.formTextInput4.Location = new System.Drawing.Point(101, 125);
            this.formTextInput4.Name = "formTextInput4";
            this.formTextInput4.RegularExpression = null;
            this.formTextInput4.Size = new System.Drawing.Size(200, 50);
            this.formTextInput4.TabIndex = 3;
            // 
            // formTextInput3
            // 
            this.formTextInput3.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formTextInput3.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formTextInput3.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formTextInput3.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formTextInput3.ErrorMessage = "";
            this.formTextInput3.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput3.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formTextInput3.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput3.FieldName = "phone_number";
            this.formTextInput3.FieldSize = new System.Drawing.Size(200, 20);
            this.formTextInput3.Location = new System.Drawing.Point(101, 94);
            this.formTextInput3.Name = "formTextInput3";
            this.formTextInput3.RegularExpression = null;
            this.formTextInput3.Size = new System.Drawing.Size(200, 50);
            this.formTextInput3.TabIndex = 2;
            // 
            // formTextInput2
            // 
            this.formTextInput2.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formTextInput2.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formTextInput2.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formTextInput2.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formTextInput2.ErrorMessage = "";
            this.formTextInput2.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput2.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formTextInput2.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput2.FieldName = "surname";
            this.formTextInput2.FieldSize = new System.Drawing.Size(200, 20);
            this.formTextInput2.Location = new System.Drawing.Point(101, 63);
            this.formTextInput2.Name = "formTextInput2";
            this.formTextInput2.RegularExpression = null;
            this.formTextInput2.Size = new System.Drawing.Size(200, 50);
            this.formTextInput2.TabIndex = 1;
            this.formTextInput2.Load += new System.EventHandler(this.formTextInput2_Load);
            // 
            // formTextInput1
            // 
            this.formTextInput1.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formTextInput1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formTextInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formTextInput1.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formTextInput1.ErrorMessage = "";
            this.formTextInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formTextInput1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formTextInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formTextInput1.FieldName = "name";
            this.formTextInput1.FieldSize = new System.Drawing.Size(200, 20);
            this.formTextInput1.Location = new System.Drawing.Point(101, 32);
            this.formTextInput1.Name = "formTextInput1";
            this.formTextInput1.RegularExpression = null;
            this.formTextInput1.Size = new System.Drawing.Size(200, 50);
            this.formTextInput1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wynik";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.form2.ResumeLayout(false);
            this.form2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormComponent.Form form2;
        private FormComponent.FormTextInput formTextInput1;
        private FormComponent.FormTextInput formTextInput4;
        private FormComponent.FormTextInput formTextInput3;
        private FormComponent.FormTextInput formTextInput2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}