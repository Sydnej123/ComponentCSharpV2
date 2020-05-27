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
            this.form2 = new FormComponent.Form(this.components);
            this.formComboBox1 = new FormComponent.FormComboBox(this.components);
            this.form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2
            // 
            this.form2.ControlGrid = true;
            this.form2.Controls.Add(this.formComboBox1);
            this.form2.ControlsMarginBottom = 0;
            this.form2.ControlsMarginLeft = 0;
            this.form2.ControlsMarginRight = 0;
            this.form2.ControlsMarginTop = 0;
            this.form2.ControlsSizeFillToParent = true;
            this.form2.ErrorPosition = new System.Drawing.Point(0, 20);
            this.form2.ErrorSize = new System.Drawing.Size(200, 20);
            this.form2.FieldsSize = new System.Drawing.Size(200, 40);
            this.form2.Location = new System.Drawing.Point(161, 96);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(478, 150);
            this.form2.TabIndex = 0;
            // 
            // formComboBox1
            // 
            this.formComboBox1.ErrorLabelBackColor = System.Drawing.SystemColors.Control;
            this.formComboBox1.ErrorLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.formComboBox1.ErrorLabelLocation = new System.Drawing.Point(0, 20);
            this.formComboBox1.ErrorLabelSize = new System.Drawing.Size(478, 20);
            this.formComboBox1.ErrorMessage = "";
            this.formComboBox1.FieldBackColor = System.Drawing.SystemColors.Window;
            this.formComboBox1.FieldForeColor = System.Drawing.SystemColors.WindowText;
            this.formComboBox1.FieldLocation = new System.Drawing.Point(0, 0);
            this.formComboBox1.FieldName = null;
            this.formComboBox1.FieldSize = new System.Drawing.Size(478, 21);
            this.formComboBox1.HideErrorMessageOnChange = false;
            this.formComboBox1.IsRequired = false;
            this.formComboBox1.Items = new FormComponent.FormComboBoxOption[0];
            this.formComboBox1.Location = new System.Drawing.Point(0, 47);
            this.formComboBox1.Name = "formComboBox1";
            this.formComboBox1.Size = new System.Drawing.Size(478, 40);
            this.formComboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(462, 471);
            this.Controls.Add(this.form2);
            this.Name = "Form1";
            this.form2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private FormComponent.Form form2;
        private FormComponent.FormComboBox formComboBox1;
    }
}

