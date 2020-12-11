
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
            this.nameMallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPavilionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterCityLb = new System.Windows.Forms.Label();
            this.filterStatusLb = new System.Windows.Forms.Label();
            this.filterCityCmb = new System.Windows.Forms.ComboBox();
            this.filterStatusCmb = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.sortStatusButton = new System.Windows.Forms.Button();
            this.sortCityButton = new System.Windows.Forms.Button();
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
            // exitButton
            // 
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameMallDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.quantityPavilionDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.сoefficientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 354);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameMallDataGridViewTextBoxColumn
            // 
            this.nameMallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nameMallDataGridViewTextBoxColumn.DataPropertyName = "NameMall";
            this.nameMallDataGridViewTextBoxColumn.HeaderText = "Название";
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
            this.quantityPavilionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityPavilionDataGridViewTextBoxColumn.DataPropertyName = "QuantityPavilion";
            this.quantityPavilionDataGridViewTextBoxColumn.HeaderText = "Кол-ство павильонов";
            this.quantityPavilionDataGridViewTextBoxColumn.Name = "quantityPavilionDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 21;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Этажность";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // сoefficientDataGridViewTextBoxColumn
            // 
            this.сoefficientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сoefficientDataGridViewTextBoxColumn.DataPropertyName = "Сoefficient";
            this.сoefficientDataGridViewTextBoxColumn.HeaderText = "КДС ТЦ";
            this.сoefficientDataGridViewTextBoxColumn.Name = "сoefficientDataGridViewTextBoxColumn";
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(TestAttempt.ModelEF.Mall);
            // 
            // filterCityLb
            // 
            this.filterCityLb.AutoSize = true;
            this.filterCityLb.Location = new System.Drawing.Point(303, 103);
            this.filterCityLb.Name = "filterCityLb";
            this.filterCityLb.Size = new System.Drawing.Size(186, 19);
            this.filterCityLb.TabIndex = 4;
            this.filterCityLb.Text = "Фильтровать по городу:";
            // 
            // filterStatusLb
            // 
            this.filterStatusLb.AutoSize = true;
            this.filterStatusLb.Location = new System.Drawing.Point(303, 136);
            this.filterStatusLb.Name = "filterStatusLb";
            this.filterStatusLb.Size = new System.Drawing.Size(195, 19);
            this.filterStatusLb.TabIndex = 5;
            this.filterStatusLb.Text = "Фильтровать по статусу:";
            // 
            // filterCityCmb
            // 
            this.filterCityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCityCmb.FormattingEnabled = true;
            this.filterCityCmb.Location = new System.Drawing.Point(504, 100);
            this.filterCityCmb.Name = "filterCityCmb";
            this.filterCityCmb.Size = new System.Drawing.Size(230, 27);
            this.filterCityCmb.TabIndex = 6;
            this.filterCityCmb.SelectionChangeCommitted += new System.EventHandler(this.filterCityCmb_SelectionChangeCommitted);
            // 
            // filterStatusCmb
            // 
            this.filterStatusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterStatusCmb.FormattingEnabled = true;
            this.filterStatusCmb.Location = new System.Drawing.Point(504, 133);
            this.filterStatusCmb.Name = "filterStatusCmb";
            this.filterStatusCmb.Size = new System.Drawing.Size(230, 27);
            this.filterStatusCmb.TabIndex = 7;
            this.filterStatusCmb.SelectionChangeCommitted += new System.EventHandler(this.filterStatusCmb_SelectionChangeCommitted);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(759, 108);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(209, 30);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Показать исходное";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sortStatusButton
            // 
            this.sortStatusButton.Location = new System.Drawing.Point(12, 136);
            this.sortStatusButton.Name = "sortStatusButton";
            this.sortStatusButton.Size = new System.Drawing.Size(211, 28);
            this.sortStatusButton.TabIndex = 9;
            this.sortStatusButton.Text = "Сортировка по статусу";
            this.sortStatusButton.UseVisualStyleBackColor = true;
            this.sortStatusButton.Click += new System.EventHandler(this.sortStatusButton_Click);
            // 
            // sortCityButton
            // 
            this.sortCityButton.Location = new System.Drawing.Point(12, 96);
            this.sortCityButton.Name = "sortCityButton";
            this.sortCityButton.Size = new System.Drawing.Size(211, 26);
            this.sortCityButton.TabIndex = 10;
            this.sortCityButton.Text = "Сортировка по городу";
            this.sortCityButton.UseVisualStyleBackColor = true;
            this.sortCityButton.Click += new System.EventHandler(this.sortCityButton_Click);
            // 
            // FormOfManagerC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 589);
            this.Controls.Add(this.sortCityButton);
            this.Controls.Add(this.sortStatusButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.filterStatusCmb);
            this.Controls.Add(this.filterCityCmb);
            this.Controls.Add(this.filterStatusLb);
            this.Controls.Add(this.filterCityLb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOfManagerC";
            this.Text = "Рабочий стол менеджера С";
            this.Load += new System.EventHandler(this.FormOfManagerC_Load);
            this.Controls.SetChildIndex(this.logoFormPic, 0);
            this.Controls.SetChildIndex(this.nameFormLb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.filterCityLb, 0);
            this.Controls.SetChildIndex(this.filterStatusLb, 0);
            this.Controls.SetChildIndex(this.filterCityCmb, 0);
            this.Controls.SetChildIndex(this.filterStatusCmb, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.sortStatusButton, 0);
            this.Controls.SetChildIndex(this.sortCityButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoFormPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mallBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPavilionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сoefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label filterCityLb;
        private System.Windows.Forms.Label filterStatusLb;
        private System.Windows.Forms.ComboBox filterCityCmb;
        private System.Windows.Forms.ComboBox filterStatusCmb;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button sortStatusButton;
        private System.Windows.Forms.Button sortCityButton;
    }
}