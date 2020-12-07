
namespace TestAttempt
{
    partial class BasicForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoFormPic = new System.Windows.Forms.PictureBox();
            this.nameFormLb = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logoFormPic
            // 
            this.logoFormPic.Image = global::TestAttempt.Properties.Resources.цветоккапля;
            this.logoFormPic.Location = new System.Drawing.Point(246, 13);
            this.logoFormPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoFormPic.Name = "logoFormPic";
            this.logoFormPic.Size = new System.Drawing.Size(78, 67);
            this.logoFormPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoFormPic.TabIndex = 0;
            this.logoFormPic.TabStop = false;
            // 
            // nameFormLb
            // 
            this.nameFormLb.AutoSize = true;
            this.nameFormLb.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFormLb.Location = new System.Drawing.Point(332, 33);
            this.nameFormLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameFormLb.Name = "nameFormLb";
            this.nameFormLb.Size = new System.Drawing.Size(118, 24);
            this.nameFormLb.TabIndex = 1;
            this.nameFormLb.Text = "Название";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.Location = new System.Drawing.Point(12, 550);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 597);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameFormLb);
            this.Controls.Add(this.logoFormPic);
            this.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BasicForm";
            this.Text = "BasicForm";
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoFormPic;
        private System.Windows.Forms.Label nameFormLb;
        private System.Windows.Forms.Button exitButton;
    }
}

