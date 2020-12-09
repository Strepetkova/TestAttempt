
namespace TestAttempt
{
    partial class InterfaceOfManagerA
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
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLb = new System.Windows.Forms.Label();
            this.phoneLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.phoneMaskTb = new System.Windows.Forms.MaskedTextBox();
            this.addressRichTb = new System.Windows.Forms.RichTextBox();
            this.changeLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logoFormPic
            // 
            this.logoFormPic.Location = new System.Drawing.Point(142, 13);
            // 
            // nameFormLb
            // 
            this.nameFormLb.Location = new System.Drawing.Point(228, 30);
            this.nameFormLb.Size = new System.Drawing.Size(293, 24);
            this.nameFormLb.Text = "Интерфейс менеджера А";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 426);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Silver;
            this.saveButton.Location = new System.Drawing.Point(553, 426);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(119, 134);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(89, 19);
            this.nameLb.TabIndex = 4;
            this.nameLb.Text = "Название:";
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(128, 206);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(80, 19);
            this.phoneLb.TabIndex = 5;
            this.phoneLb.Text = "Телефон:";
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Location = new System.Drawing.Point(150, 281);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(58, 19);
            this.addressLb.TabIndex = 6;
            this.addressLb.Text = "Адрес:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(259, 128);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(239, 25);
            this.nameTb.TabIndex = 7;
            // 
            // phoneMaskTb
            // 
            this.phoneMaskTb.Location = new System.Drawing.Point(259, 200);
            this.phoneMaskTb.Mask = "+7(999) 000-0000";
            this.phoneMaskTb.Name = "phoneMaskTb";
            this.phoneMaskTb.Size = new System.Drawing.Size(239, 25);
            this.phoneMaskTb.TabIndex = 8;
            // 
            // addressRichTb
            // 
            this.addressRichTb.Location = new System.Drawing.Point(259, 278);
            this.addressRichTb.Name = "addressRichTb";
            this.addressRichTb.Size = new System.Drawing.Size(239, 96);
            this.addressRichTb.TabIndex = 9;
            this.addressRichTb.Text = "";
            // 
            // changeLb
            // 
            this.changeLb.AutoSize = true;
            this.changeLb.BackColor = System.Drawing.Color.White;
            this.changeLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.changeLb.Location = new System.Drawing.Point(227, 61);
            this.changeLb.Name = "changeLb";
            this.changeLb.Size = new System.Drawing.Size(192, 19);
            this.changeLb.TabIndex = 10;
            this.changeLb.Text = "Добавление арендатора";
            // 
            // InterfaceOfManagerA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 474);
            this.Controls.Add(this.changeLb);
            this.Controls.Add(this.addressRichTb);
            this.Controls.Add(this.phoneMaskTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.saveButton);
            this.Name = "InterfaceOfManagerA";
            this.Text = "Интерфейс менеджера А";
            this.Load += new System.EventHandler(this.InterfaceOfManagerA_Load);
            this.Controls.SetChildIndex(this.logoFormPic, 0);
            this.Controls.SetChildIndex(this.nameFormLb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.phoneLb, 0);
            this.Controls.SetChildIndex(this.addressLb, 0);
            this.Controls.SetChildIndex(this.nameTb, 0);
            this.Controls.SetChildIndex(this.phoneMaskTb, 0);
            this.Controls.SetChildIndex(this.addressRichTb, 0);
            this.Controls.SetChildIndex(this.changeLb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.MaskedTextBox phoneMaskTb;
        private System.Windows.Forms.RichTextBox addressRichTb;
        private System.Windows.Forms.Label changeLb;
    }
}