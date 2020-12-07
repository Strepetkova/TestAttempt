
namespace TestAttempt
{
    partial class FormOfManagerC
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
            this.helloLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFormLb
            // 
            this.nameFormLb.Size = new System.Drawing.Size(316, 24);
            this.nameFormLb.Text = "Список торговых центров";
            // 
            // exitButton
            // 
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helloLb
            // 
            this.helloLb.AutoSize = true;
            this.helloLb.ForeColor = System.Drawing.Color.Navy;
            this.helloLb.Location = new System.Drawing.Point(265, 93);
            this.helloLb.Name = "helloLb";
            this.helloLb.Size = new System.Drawing.Size(157, 19);
            this.helloLb.TabIndex = 3;
            this.helloLb.Text = "Добро пожаловать, ";
            // 
            // FormOfManagerC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 599);
            this.Controls.Add(this.helloLb);
            this.Name = "FormOfManagerC";
            this.Text = "Рабочий стол Менеджера С";
            this.Load += new System.EventHandler(this.FormOfManagerC_Load);
            this.Controls.SetChildIndex(this.logoFormPic, 0);
            this.Controls.SetChildIndex(this.nameFormLb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.helloLb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLb;
    }
}