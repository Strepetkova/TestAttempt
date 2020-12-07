
namespace TestAttempt
{
    partial class Registation
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
            this.nameLb = new System.Windows.Forms.Label();
            this.surnameLb = new System.Windows.Forms.Label();
            this.middleNameLb = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.repeatPassLb = new System.Windows.Forms.Label();
            this.roleLb = new System.Windows.Forms.Label();
            this.phoneLb = new System.Windows.Forms.Label();
            this.genderLb = new System.Windows.Forms.Label();
            this.photoLb = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.middleNameTb = new System.Windows.Forms.TextBox();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.repeatPassTb = new System.Windows.Forms.TextBox();
            this.passwordLb = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.roleCmb = new System.Windows.Forms.ComboBox();
            this.phoneMaskTb = new System.Windows.Forms.MaskedTextBox();
            this.genderTb = new System.Windows.Forms.TextBox();
            this.photoPic = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.attachButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFormLb
            // 
            this.nameFormLb.Size = new System.Drawing.Size(156, 24);
            this.nameFormLb.Text = "Регистрация";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 616);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(212, 120);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(46, 19);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "Имя:";
            // 
            // surnameLb
            // 
            this.surnameLb.AutoSize = true;
            this.surnameLb.Location = new System.Drawing.Point(175, 169);
            this.surnameLb.Name = "surnameLb";
            this.surnameLb.Size = new System.Drawing.Size(83, 19);
            this.surnameLb.TabIndex = 4;
            this.surnameLb.Text = "Фамилия:";
            // 
            // middleNameLb
            // 
            this.middleNameLb.AutoSize = true;
            this.middleNameLb.Location = new System.Drawing.Point(173, 215);
            this.middleNameLb.Name = "middleNameLb";
            this.middleNameLb.Size = new System.Drawing.Size(85, 19);
            this.middleNameLb.TabIndex = 5;
            this.middleNameLb.Text = "Отчество:";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(199, 259);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(59, 19);
            this.loginLb.TabIndex = 6;
            this.loginLb.Text = "Логин:";
            // 
            // repeatPassLb
            // 
            this.repeatPassLb.AutoSize = true;
            this.repeatPassLb.Location = new System.Drawing.Point(108, 339);
            this.repeatPassLb.Name = "repeatPassLb";
            this.repeatPassLb.Size = new System.Drawing.Size(150, 19);
            this.repeatPassLb.TabIndex = 7;
            this.repeatPassLb.Text = "Повторите пароль:";
            // 
            // roleLb
            // 
            this.roleLb.AutoSize = true;
            this.roleLb.Location = new System.Drawing.Point(211, 383);
            this.roleLb.Name = "roleLb";
            this.roleLb.Size = new System.Drawing.Size(47, 19);
            this.roleLb.TabIndex = 8;
            this.roleLb.Text = "Роль:";
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(178, 419);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(80, 19);
            this.phoneLb.TabIndex = 9;
            this.phoneLb.Text = "Телефон:";
            // 
            // genderLb
            // 
            this.genderLb.AutoSize = true;
            this.genderLb.Location = new System.Drawing.Point(216, 460);
            this.genderLb.Name = "genderLb";
            this.genderLb.Size = new System.Drawing.Size(42, 19);
            this.genderLb.TabIndex = 10;
            this.genderLb.Text = "Пол:";
            // 
            // photoLb
            // 
            this.photoLb.AutoSize = true;
            this.photoLb.Location = new System.Drawing.Point(152, 528);
            this.photoLb.Name = "photoLb";
            this.photoLb.Size = new System.Drawing.Size(106, 19);
            this.photoLb.TabIndex = 11;
            this.photoLb.Text = "Фотография:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(279, 117);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(239, 25);
            this.nameTb.TabIndex = 12;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(279, 166);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(239, 25);
            this.surnameTb.TabIndex = 13;
            // 
            // middleNameTb
            // 
            this.middleNameTb.Location = new System.Drawing.Point(279, 212);
            this.middleNameTb.Name = "middleNameTb";
            this.middleNameTb.Size = new System.Drawing.Size(239, 25);
            this.middleNameTb.TabIndex = 14;
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(279, 256);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(239, 25);
            this.loginTb.TabIndex = 15;
            // 
            // repeatPassTb
            // 
            this.repeatPassTb.Location = new System.Drawing.Point(279, 336);
            this.repeatPassTb.Name = "repeatPassTb";
            this.repeatPassTb.Size = new System.Drawing.Size(239, 25);
            this.repeatPassTb.TabIndex = 16;
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(191, 296);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(67, 19);
            this.passwordLb.TabIndex = 17;
            this.passwordLb.Text = "Пароль:";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(279, 293);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(239, 25);
            this.passwordTb.TabIndex = 18;
            // 
            // roleCmb
            // 
            this.roleCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCmb.FormattingEnabled = true;
            this.roleCmb.Location = new System.Drawing.Point(279, 380);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(239, 27);
            this.roleCmb.TabIndex = 19;
            // 
            // phoneMaskTb
            // 
            this.phoneMaskTb.Location = new System.Drawing.Point(279, 419);
            this.phoneMaskTb.Mask = "+7(999) 000-0000";
            this.phoneMaskTb.Name = "phoneMaskTb";
            this.phoneMaskTb.Size = new System.Drawing.Size(239, 25);
            this.phoneMaskTb.TabIndex = 20;
            // 
            // genderTb
            // 
            this.genderTb.Location = new System.Drawing.Point(279, 457);
            this.genderTb.Name = "genderTb";
            this.genderTb.Size = new System.Drawing.Size(239, 25);
            this.genderTb.TabIndex = 21;
            // 
            // photoPic
            // 
            this.photoPic.Location = new System.Drawing.Point(279, 498);
            this.photoPic.Name = "photoPic";
            this.photoPic.Size = new System.Drawing.Size(119, 78);
            this.photoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPic.TabIndex = 22;
            this.photoPic.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Silver;
            this.saveButton.Location = new System.Drawing.Point(639, 616);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 35);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(279, 582);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(110, 28);
            this.attachButton.TabIndex = 24;
            this.attachButton.Text = "Прикрепить";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // Registation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 663);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.photoPic);
            this.Controls.Add(this.genderTb);
            this.Controls.Add(this.phoneMaskTb);
            this.Controls.Add(this.roleCmb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.repeatPassTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.middleNameTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.photoLb);
            this.Controls.Add(this.genderLb);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.roleLb);
            this.Controls.Add(this.repeatPassLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.middleNameLb);
            this.Controls.Add(this.surnameLb);
            this.Controls.Add(this.nameLb);
            this.Name = "Registation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registation_Load);
            this.Controls.SetChildIndex(this.logoFormPic, 0);
            this.Controls.SetChildIndex(this.nameFormLb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.surnameLb, 0);
            this.Controls.SetChildIndex(this.middleNameLb, 0);
            this.Controls.SetChildIndex(this.loginLb, 0);
            this.Controls.SetChildIndex(this.repeatPassLb, 0);
            this.Controls.SetChildIndex(this.roleLb, 0);
            this.Controls.SetChildIndex(this.phoneLb, 0);
            this.Controls.SetChildIndex(this.genderLb, 0);
            this.Controls.SetChildIndex(this.photoLb, 0);
            this.Controls.SetChildIndex(this.nameTb, 0);
            this.Controls.SetChildIndex(this.surnameTb, 0);
            this.Controls.SetChildIndex(this.middleNameTb, 0);
            this.Controls.SetChildIndex(this.loginTb, 0);
            this.Controls.SetChildIndex(this.repeatPassTb, 0);
            this.Controls.SetChildIndex(this.passwordLb, 0);
            this.Controls.SetChildIndex(this.passwordTb, 0);
            this.Controls.SetChildIndex(this.roleCmb, 0);
            this.Controls.SetChildIndex(this.phoneMaskTb, 0);
            this.Controls.SetChildIndex(this.genderTb, 0);
            this.Controls.SetChildIndex(this.photoPic, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.attachButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label surnameLb;
        private System.Windows.Forms.Label middleNameLb;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label repeatPassLb;
        private System.Windows.Forms.Label roleLb;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.Label genderLb;
        private System.Windows.Forms.Label photoLb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox middleNameTb;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox repeatPassTb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.ComboBox roleCmb;
        private System.Windows.Forms.MaskedTextBox phoneMaskTb;
        private System.Windows.Forms.TextBox genderTb;
        private System.Windows.Forms.PictureBox photoPic;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button attachButton;
    }
}