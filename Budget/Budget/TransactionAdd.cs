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
    public partial class TransactionAdd : Form
    {
        public string Name;
        public int ID;

        public BudgetDatabaseEntities Database;
        public TransactionAdd()
        {
            InitializeComponent();
            Database = new BudgetDatabaseEntities();
        }
        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Transaction NewTransaction = new Transaction();
            NewTransaction.Date = DateTimePicker.Value.Date.ToString();
            NewTransaction.Id = ID;
            NewTransaction.Expenses = ExpensesBox.Text;
            NewTransaction.Price = Convert.ToInt32(PriceBox.Text);
            Database.Transactions.Add(NewTransaction);
            Database.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionMenu TM = new TransactionMenu();
            TM.LoadInfo(Name, ID);
            TM.ShowDialog();
        }
    }
}
