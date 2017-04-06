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
    public partial class incomeDataGrid : Form
    {
        public incomeDataGrid()
        {
            InitializeComponent();
        }

        private void incomeDataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetDatabaseDataSet1.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.budgetDatabaseDataSet1.Income);

        }
    }
}
