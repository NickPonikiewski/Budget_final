namespace Budget
{
    partial class TransactionMenu
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetDatabaseDataSet1 = new Budget.BudgetDatabaseDataSet1();
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetDatabaseDataSet = new Budget.BudgetDatabaseDataSet();
            this.transactionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableAdapter = new Budget.BudgetDatabaseDataSetTableAdapters.TransactionTableAdapter();
            this.transactionTableAdapter1 = new Budget.BudgetDatabaseDataSet1TableAdapters.TransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.expensesDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expensesDataGridViewTextBoxColumn
            // 
            this.expensesDataGridViewTextBoxColumn.DataPropertyName = "Expenses";
            this.expensesDataGridViewTextBoxColumn.HeaderText = "Expenses";
            this.expensesDataGridViewTextBoxColumn.Name = "expensesDataGridViewTextBoxColumn";
            this.expensesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionBindingSource4
            // 
            this.transactionBindingSource4.DataMember = "Transaction";
            this.transactionBindingSource4.DataSource = this.budgetDatabaseDataSet1BindingSource;
            // 
            // budgetDatabaseDataSet1BindingSource
            // 
            this.budgetDatabaseDataSet1BindingSource.DataSource = this.budgetDatabaseDataSet1;
            this.budgetDatabaseDataSet1BindingSource.Position = 0;
            // 
            // budgetDatabaseDataSet1
            // 
            this.budgetDatabaseDataSet1.DataSetName = "BudgetDatabaseDataSet1";
            this.budgetDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataMember = "Transaction";
            this.transactionBindingSource1.DataSource = this.budgetDatabaseDataSetBindingSource;
            // 
            // budgetDatabaseDataSetBindingSource
            // 
            this.budgetDatabaseDataSetBindingSource.DataSource = this.budgetDatabaseDataSet;
            this.budgetDatabaseDataSetBindingSource.Position = 0;
            // 
            // budgetDatabaseDataSet
            // 
            this.budgetDatabaseDataSet.DataSetName = "BudgetDatabaseDataSet";
            this.budgetDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionBindingSource2
            // 
            this.transactionBindingSource2.DataMember = "Transaction";
            this.transactionBindingSource2.DataSource = this.budgetDatabaseDataSetBindingSource;
            // 
            // transactionBindingSource3
            // 
            this.transactionBindingSource3.DataMember = "Transaction";
            this.transactionBindingSource3.DataSource = this.budgetDatabaseDataSet;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.budgetDatabaseDataSet;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTableAdapter1
            // 
            this.transactionTableAdapter1.ClearBeforeFill = true;
            // 
            // TransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 337);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TransactionMenu";
            this.Text = "TransactionMenu";
            this.Load += new System.EventHandler(this.TransactionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BudgetDatabaseDataSet budgetDatabaseDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private BudgetDatabaseDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.BindingSource budgetDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource transactionBindingSource3;
        private System.Windows.Forms.BindingSource transactionBindingSource2;
        private System.Windows.Forms.BindingSource budgetDatabaseDataSet1BindingSource;
        private BudgetDatabaseDataSet1 budgetDatabaseDataSet1;
        private System.Windows.Forms.BindingSource transactionBindingSource4;
        private BudgetDatabaseDataSet1TableAdapters.TransactionTableAdapter transactionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}