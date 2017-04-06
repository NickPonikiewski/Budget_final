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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            string Name = AccountNameBox.Text;
            int id = Convert.ToInt32(AccountIDBox.Text);
            BudgetDatabaseEntities Database = new BudgetDatabaseEntities();
            if ((Database.Accounts.Where(c => c.Id == id).SingleOrDefault() != null) && (Database.Accounts.Where(c => c.Name == Name).SingleOrDefault() != null))// if user name and id does exist in the database
            {
                MainMenu MM = new MainMenu();
                MM.LoadInfo(Name, id);
                this.Hide();
                MM.ShowDialog();
            }
            else
            {
                MessageBox.Show("User not in system", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
