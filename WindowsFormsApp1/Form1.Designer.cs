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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2
            // 
            this.form2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.form2.ControlGrid = true;
            this.form2.Controls.Add(this.button1);
            this.form2.Controls.Add(this.label7);
            this.form2.Controls.Add(this.label8);
            this.form2.Controls.Add(this.label6);
            this.form2.Controls.Add(this.label5);
            this.form2.Controls.Add(this.label4);
            this.form2.Controls.Add(this.label3);
            this.form2.Controls.Add(this.label2);
            this.form2.ControlsMarginLeft = 150;
            this.form2.ControlsMarginTop = 5;
            this.form2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.form2.ErrorPosition = new System.Drawing.Point(0, 50);
            this.form2.ErrorSize = new System.Drawing.Size(200, 20);
            this.form2.FieldsSize = new System.Drawing.Size(300, 70);
            this.form2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.form2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.form2.Location = new System.Drawing.Point(-2, 1);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(493, 942);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(490, 728);
            this.Controls.Add(this.form2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.form2.ResumeLayout(false);
            this.form2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormComponent.Form form2;
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

