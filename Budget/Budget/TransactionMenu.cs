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
    public partial class TransactionMenu : Form
    {
        public string Name;
        public int ID;
        public TransactionMenu()
        {
            InitializeComponent();
        }
        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }

        private void TransactionMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetDatabaseDataSet1.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter1.Fill(this.budgetDatabaseDataSet1.Transaction);
            // TODO: This line of code loads data into the 'budgetDatabaseDataSet.Transaction' table. You can move, or remove it, as needed.
            //this.transactionTableAdapter.Fill(this.budgetDatabaseDataSet.Transaction);

            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                MessageBox.Show("Value: " + dr.Cells[0].Value + "");
                if ((Convert.ToInt32(dr.Cells[0].Value) != ID))
                {
                    dr.Visible = false;
                }
            }

        }

    }
}
