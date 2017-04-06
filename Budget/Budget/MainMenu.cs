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
    public partial class MainMenu : Form
    {
        public string Name;
        public int ID;
        public MainMenu()
        {
            InitializeComponent();
        }
        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }

        private void Transactionbutton_Click(object sender, EventArgs e)
        {
            TransactionAdd TM = new TransactionAdd();
            TM.LoadInfo(Name, ID);
            TM.ShowDialog();
        }

        private void Budgetbutton_Click(object sender, EventArgs e)
        {
            //add here
        }
    }
}
