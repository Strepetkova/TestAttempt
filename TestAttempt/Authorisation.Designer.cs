
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
            this.signInButton = new System.Windows.Forms.Button();
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logoFormPic
            // 
            this.logoFormPic.Location = new System.Drawing.Point(183, 16);
            // 
            // nameFormLb
            // 
            this.nameFormLb.Location = new System.Drawing.Point(287, 36);
            this.nameFormLb.Size = new System.Drawing.Size(159, 24);
            this.nameFormLb.Text = "Авторизация";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 398);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Silver;
            this.signInButton.Location = new System.Drawing.Point(262, 245);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(184, 34);
            this.signInButton.TabIndex = 3;
            this.signInButton.Text = "Авторизоваться";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(187, 125);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(59, 19);
            this.loginLb.TabIndex = 4;
            this.loginLb.Text = "Логин:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(179, 185);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(67, 19);
            this.passwordLb.TabIndex = 5;
            this.passwordLb.Text = "Пароль:";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(291, 125);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(228, 25);
            this.loginTB.TabIndex = 6;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(291, 182);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(228, 25);
            this.passwordTb.TabIndex = 7;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Silver;
            this.SignUpButton.Location = new System.Drawing.Point(262, 300);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(184, 32);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Зарегистрироваться";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 445);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.signInButton);
            this.Name = "Authorisation";
            this.Text = "Авторизация";
            this.Controls.SetChildIndex(this.logoFormPic, 0);
            this.Controls.SetChildIndex(this.nameFormLb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.signInButton, 0);
            this.Controls.SetChildIndex(this.loginLb, 0);
            this.Controls.SetChildIndex(this.passwordLb, 0);
            this.Controls.SetChildIndex(this.loginTB, 0);
            this.Controls.SetChildIndex(this.passwordTb, 0);
            this.Controls.SetChildIndex(this.SignUpButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button SignUpButton;
    }
}