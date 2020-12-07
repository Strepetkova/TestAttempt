
namespace TestAttempt
{
    partial class Authorisation
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
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFormLb
            // 
            this.nameFormLb.Size = new System.Drawing.Size(159, 24);
            this.nameFormLb.Text = "Авторизация";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 484);
            // 
            // Authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 531);
            this.Name = "Authorisation";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}