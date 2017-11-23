namespace ANACONDA
{
    partial class Form_MAIN
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_test_paul = new System.Windows.Forms.Button();
            this.btn_klaus_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(92, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "OK";
            // 
            // btn_test_paul
            // 
            this.btn_test_paul.Location = new System.Drawing.Point(305, 8);
            this.btn_test_paul.Margin = new System.Windows.Forms.Padding(2);
            this.btn_test_paul.Name = "btn_test_paul";
            this.btn_test_paul.Size = new System.Drawing.Size(127, 45);
            this.btn_test_paul.TabIndex = 2;
            this.btn_test_paul.Text = "paul test button";
            this.btn_test_paul.UseVisualStyleBackColor = true;
            this.btn_test_paul.Click += new System.EventHandler(this.btn_test_paul_Click);
            // 
            // btn_klaus_test
            // 
            this.btn_klaus_test.Location = new System.Drawing.Point(303, 57);
            this.btn_klaus_test.Margin = new System.Windows.Forms.Padding(2);
            this.btn_klaus_test.Name = "btn_klaus_test";
            this.btn_klaus_test.Size = new System.Drawing.Size(127, 45);
            this.btn_klaus_test.TabIndex = 3;
            this.btn_klaus_test.Text = "Klaus test button";
            this.btn_klaus_test.UseVisualStyleBackColor = true;
            this.btn_klaus_test.Click += new System.EventHandler(this.btn_klaus_test_Click);
            // 
            // Form_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(441, 355);
            this.Controls.Add(this.btn_klaus_test);
            this.Controls.Add(this.btn_test_paul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_MAIN";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_test_paul;
        private System.Windows.Forms.Button btn_klaus_test;
    }
}

