namespace Budget
{
    partial class expensesDataGrid
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
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new Budget.BudgetDatabaseDataSet1TableAdapters.ExpensesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.householdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leisureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularBillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherBillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalExpensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.householdDataGridViewTextBoxColumn,
            this.transportDataGridViewTextBoxColumn,
            this.financeDataGridViewTextBoxColumn,
            this.leisureDataGridViewTextBoxColumn,
            this.regularBillsDataGridViewTextBoxColumn,
            this.insuranceDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.otherBillsDataGridViewTextBoxColumn,
            this.totalExpensesDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expensesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // budgetDatabaseDataSet1
            // 
            this.budgetDatabaseDataSet1.DataSetName = "BudgetDatabaseDataSet1";
            this.budgetDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.budgetDatabaseDataSet1;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // householdDataGridViewTextBoxColumn
            // 
            this.householdDataGridViewTextBoxColumn.DataPropertyName = "household";
            this.householdDataGridViewTextBoxColumn.HeaderText = "household";
            this.householdDataGridViewTextBoxColumn.Name = "householdDataGridViewTextBoxColumn";
            // 
            // transportDataGridViewTextBoxColumn
            // 
            this.transportDataGridViewTextBoxColumn.DataPropertyName = "transport";
            this.transportDataGridViewTextBoxColumn.HeaderText = "transport";
            this.transportDataGridViewTextBoxColumn.Name = "transportDataGridViewTextBoxColumn";
            // 
            // financeDataGridViewTextBoxColumn
            // 
            this.financeDataGridViewTextBoxColumn.DataPropertyName = "finance";
            this.financeDataGridViewTextBoxColumn.HeaderText = "finance";
            this.financeDataGridViewTextBoxColumn.Name = "financeDataGridViewTextBoxColumn";
            // 
            // leisureDataGridViewTextBoxColumn
            // 
            this.leisureDataGridViewTextBoxColumn.DataPropertyName = "leisure";
            this.leisureDataGridViewTextBoxColumn.HeaderText = "leisure";
            this.leisureDataGridViewTextBoxColumn.Name = "leisureDataGridViewTextBoxColumn";
            // 
            // regularBillsDataGridViewTextBoxColumn
            // 
            this.regularBillsDataGridViewTextBoxColumn.DataPropertyName = "regularBills";
            this.regularBillsDataGridViewTextBoxColumn.HeaderText = "regularBills";
            this.regularBillsDataGridViewTextBoxColumn.Name = "regularBillsDataGridViewTextBoxColumn";
            // 
            // insuranceDataGridViewTextBoxColumn
            // 
            this.insuranceDataGridViewTextBoxColumn.DataPropertyName = "insurance";
            this.insuranceDataGridViewTextBoxColumn.HeaderText = "insurance";
            this.insuranceDataGridViewTextBoxColumn.Name = "insuranceDataGridViewTextBoxColumn";
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // otherBillsDataGridViewTextBoxColumn
            // 
            this.otherBillsDataGridViewTextBoxColumn.DataPropertyName = "otherBills";
            this.otherBillsDataGridViewTextBoxColumn.HeaderText = "otherBills";
            this.otherBillsDataGridViewTextBoxColumn.Name = "otherBillsDataGridViewTextBoxColumn";
            // 
            // totalExpensesDataGridViewTextBoxColumn
            // 
            this.totalExpensesDataGridViewTextBoxColumn.DataPropertyName = "totalExpenses";
            this.totalExpensesDataGridViewTextBoxColumn.HeaderText = "totalExpenses";
            this.totalExpensesDataGridViewTextBoxColumn.Name = "totalExpensesDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // expensesDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 668);
            this.Controls.Add(this.dataGridView1);
            this.Name = "expensesDataGrid";
            this.Text = "expenc";
            this.Load += new System.EventHandler(this.expensesDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BudgetDatabaseDataSet1 budgetDatabaseDataSet1;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private BudgetDatabaseDataSet1TableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn householdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn financeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leisureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regularBillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherBillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalExpensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
    }
}