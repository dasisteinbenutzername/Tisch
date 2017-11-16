namespace ANACONDA.Anwendungen.Simulation
{
    partial class Simulations_Form
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
            this.panel_test = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_test
            // 
            this.panel_test.Location = new System.Drawing.Point(13, 14);
            this.panel_test.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(900, 923);
            this.panel_test.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1220, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 207);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Simulations_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 1047);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_test);
            this.Name = "Simulations_Form";
            this.Text = "Simulations_Form";
            this.Load += new System.EventHandler(this.Simulations_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Button button1;
    }
}