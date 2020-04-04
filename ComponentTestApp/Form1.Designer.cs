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
            this.form2 = new FormComponent.Form(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formCheckboxInput1 = new FormComponent.FormCheckboxInput(this.components);
            this.formPasswordInput1 = new FormComponent.FormPasswordInput(this.components);
            this.formTextInput1 = new FormComponent.FormTextInput(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2
            // 
            this.form2.Controls.Add(this.label3);
            this.form2.Controls.Add(this.label2);
            this.form2.Controls.Add(this.label1);
            this.form2.Controls.Add(this.formCheckboxInput1);
            this.form2.Controls.Add(this.formPasswordInput1);
            this.form2.Controls.Add(this.formTextInput1);
            this.form2.Controls.Add(this.button1);
            this.form2.Location = new System.Drawing.Point(245, 40);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(348, 332);
            this.form2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Akceptuje regulamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formCheckboxInput1
            // 
            this.formCheckboxInput1.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formCheckboxInput1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formCheckboxInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formCheckboxInput1.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formCheckboxInput1.ErrorMessage = "";
            this.formCheckboxInput1.FieldBackColor = System.Drawing.SystemColors.Control;
            this.formCheckboxInput1.FieldForeColor = System.Drawing.SystemColors.ControlText;
            this.formCheckboxInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formCheckboxInput1.FieldName = "regulamin";
            this.formCheckboxInput1.FieldSize = new System.Drawing.Size(200, 30);
            this.formCheckboxInput1.Location = new System.Drawing.Point(68, 181);
            this.formCheckboxInput1.Name = "formCheckboxInput1";
            this.formCheckboxInput1.Required = false;
            this.formCheckboxInput1.Size = new System.Drawing.Size(200, 50);
            this.formCheckboxInput1.TabIndex = 3;
            // 
            // formPasswordInput1
            // 
            this.formPasswordInput1.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formPasswordInput1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formPasswordInput1.ErrorLabelLocation = new System.Drawing.Point(0, 35);
            this.formPasswordInput1.ErrorLabelSize = new System.Drawing.Size(200, 15);
            this.formPasswordInput1.ErrorMessage = "";
            this.formPasswordInput1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formPasswordInput1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formPasswordInput1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formPasswordInput1.FieldName = "password";
            this.formPasswordInput1.FieldSize = new System.Drawing.Size(200, 20);
            this.formPasswordInput1.Location = new System.Drawing.Point(68, 125);
            this.formPasswordInput1.Name = "formPasswordInput1";
            this.formPasswordInput1.RegularExpression = null;
            this.formPasswordInput1.Size = new System.Drawing.Size(200, 50);
            this.formPasswordInput1.TabIndex = 2;
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
            this.formTextInput1.FieldName = "login";
            this.formTextInput1.FieldSize = new System.Drawing.Size(200, 20);
            this.formTextInput1.Location = new System.Drawing.Point(68, 69);
            this.formTextInput1.Name = "formTextInput1";
            this.formTextInput1.RegularExpression = null;
            this.formTextInput1.Size = new System.Drawing.Size(200, 50);
            this.formTextInput1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.form2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.form2.ResumeLayout(false);
            this.form2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormComponent.Form form2;
        private System.Windows.Forms.Button button1;
        private FormComponent.FormTextInput formTextInput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FormComponent.FormCheckboxInput formCheckboxInput1;
        private FormComponent.FormPasswordInput formPasswordInput1;
        private System.Windows.Forms.Label label4;
    }
}