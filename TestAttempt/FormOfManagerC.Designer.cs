
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameMallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPavilionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logoFormPic
            // 
            this.logoFormPic.Location = new System.Drawing.Point(270, 13);
            // 
            // nameFormLb
            // 
            this.nameFormLb.Location = new System.Drawing.Point(356, 32);
            this.nameFormLb.Size = new System.Drawing.Size(316, 24);
            this.nameFormLb.Text = "Список торговых центров";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameMallDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.quantityPavilionDataGridViewTextBoxColumn,
            this.sityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.сoefficientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 354);
            this.dataGridView1.TabIndex = 3;
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(TestAttempt.ModelEF.Mall);
            // 
            // nameMallDataGridViewTextBoxColumn
            // 
            this.nameMallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nameMallDataGridViewTextBoxColumn.DataPropertyName = "NameMall";
            this.nameMallDataGridViewTextBoxColumn.HeaderText = "Название ТЦ";
            this.nameMallDataGridViewTextBoxColumn.Name = "nameMallDataGridViewTextBoxColumn";
            this.nameMallDataGridViewTextBoxColumn.Width = 21;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 21;
            // 
            // quantityPavilionDataGridViewTextBoxColumn
            // 
            this.quantityPavilionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.quantityPavilionDataGridViewTextBoxColumn.DataPropertyName = "QuantityPavilion";
            this.quantityPavilionDataGridViewTextBoxColumn.HeaderText = "Кол-ство павильонов";
            this.quantityPavilionDataGridViewTextBoxColumn.Name = "quantityPavilionDataGridViewTextBoxColumn";
            this.quantityPavilionDataGridViewTextBoxColumn.Width = 21;
            // 
            // sityDataGridViewTextBoxColumn
            // 
            this.sityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.sityDataGridViewTextBoxColumn.DataPropertyName = "Sity";
            this.sityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.sityDataGridViewTextBoxColumn.Name = "sityDataGridViewTextBoxColumn";
            this.sityDataGridViewTextBoxColumn.Width = 21;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 21;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Этажность";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.Width = 21;
            // 
            // сoefficientDataGridViewTextBoxColumn
            // 
            this.сoefficientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.сoefficientDataGridViewTextBoxColumn.DataPropertyName = "Сoefficient";
            this.сoefficientDataGridViewTextBoxColumn.HeaderText = "КДС ТЦ";
            this.сoefficientDataGridViewTextBoxColumn.Name = "сoefficientDataGridViewTextBoxColumn";
            this.сoefficientDataGridViewTextBoxColumn.Width = 21;
            // 
            // FormOfManagerC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 589);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOfManagerC";
            this.Text = "Рабочий стол менеджера С";
            this.Load += new System.EventHandler(this.FormOfManagerC_Load);
            this.Controls.SetChildIndex(this.logoFormPic, 0);
            this.Controls.SetChildIndex(this.nameFormLb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPavilionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сoefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mallBindingSource;
    }
}