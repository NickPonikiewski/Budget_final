using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class expensesDataGrid : Form
    {
        public expensesDataGrid()
        {
            InitializeComponent();
        }

        private void expensesDataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetDatabaseDataSet1.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.budgetDatabaseDataSet1.Expenses);

        }
    }
}
