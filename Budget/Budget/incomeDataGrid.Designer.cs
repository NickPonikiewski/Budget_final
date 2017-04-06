namespace Budget
{
    partial class incomeDataGrid
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
            this.budgetDatabaseDataSet1 = new Budget.BudgetDatabaseDataSet1();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new Budget.BudgetDatabaseDataSet1TableAdapters.IncomeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netMonthIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingsIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.netMonthIncomeDataGridViewTextBoxColumn,
            this.pensionDataGridViewTextBoxColumn,
            this.savingsIncomeDataGridViewTextBoxColumn,
            this.otherIncomeDataGridViewTextBoxColumn,
            this.totalIncomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incomeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // budgetDatabaseDataSet1
            // 
            this.budgetDatabaseDataSet1.DataSetName = "BudgetDatabaseDataSet1";
            this.budgetDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.budgetDatabaseDataSet1;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // netMonthIncomeDataGridViewTextBoxColumn
            // 
            this.netMonthIncomeDataGridViewTextBoxColumn.DataPropertyName = "netMonthIncome";
            this.netMonthIncomeDataGridViewTextBoxColumn.HeaderText = "netMonthIncome";
            this.netMonthIncomeDataGridViewTextBoxColumn.Name = "netMonthIncomeDataGridViewTextBoxColumn";
            // 
            // pensionDataGridViewTextBoxColumn
            // 
            this.pensionDataGridViewTextBoxColumn.DataPropertyName = "pension";
            this.pensionDataGridViewTextBoxColumn.HeaderText = "pension";
            this.pensionDataGridViewTextBoxColumn.Name = "pensionDataGridViewTextBoxColumn";
            // 
            // savingsIncomeDataGridViewTextBoxColumn
            // 
            this.savingsIncomeDataGridViewTextBoxColumn.DataPropertyName = "savingsIncome";
            this.savingsIncomeDataGridViewTextBoxColumn.HeaderText = "savingsIncome";
            this.savingsIncomeDataGridViewTextBoxColumn.Name = "savingsIncomeDataGridViewTextBoxColumn";
            // 
            // otherIncomeDataGridViewTextBoxColumn
            // 
            this.otherIncomeDataGridViewTextBoxColumn.DataPropertyName = "otherIncome";
            this.otherIncomeDataGridViewTextBoxColumn.HeaderText = "otherIncome";
            this.otherIncomeDataGridViewTextBoxColumn.Name = "otherIncomeDataGridViewTextBoxColumn";
            // 
            // totalIncomeDataGridViewTextBoxColumn
            // 
            this.totalIncomeDataGridViewTextBoxColumn.DataPropertyName = "totalIncome";
            this.totalIncomeDataGridViewTextBoxColumn.HeaderText = "totalIncome";
            this.totalIncomeDataGridViewTextBoxColumn.Name = "totalIncomeDataGridViewTextBoxColumn";
            // 
            // incomeDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 381);
            this.Controls.Add(this.dataGridView1);
            this.Name = "incomeDataGrid";
            this.Text = "incomeDataGrid";
            this.Load += new System.EventHandler(this.incomeDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BudgetDatabaseDataSet1 budgetDatabaseDataSet1;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private BudgetDatabaseDataSet1TableAdapters.IncomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netMonthIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingsIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIncomeDataGridViewTextBoxColumn;
    }
}