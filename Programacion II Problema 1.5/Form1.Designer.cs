namespace Programacion_II_Problema_1._5
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
            this.cboxCLIENTES = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxCLIENTES
            // 
            this.cboxCLIENTES.FormattingEnabled = true;
            this.cboxCLIENTES.Location = new System.Drawing.Point(95, 87);
            this.cboxCLIENTES.Name = "cboxCLIENTES";
            this.cboxCLIENTES.Size = new System.Drawing.Size(278, 21);
            this.cboxCLIENTES.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxCLIENTES);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCLIENTES;
    }
}

