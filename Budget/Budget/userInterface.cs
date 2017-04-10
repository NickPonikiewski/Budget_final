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
    public partial class userInterface : Form
    {
        private BudgetDatabaseEntities budget;
        public int counter = 0;
        public string Name;
        public int ID;
        public userInterface()
        {
            InitializeComponent();
            budget = new BudgetDatabaseEntities();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
        }
        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public int goal;
        private bool incomeclicked = false;
        private bool expenseclicked = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 5)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 6)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 7)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 8)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 9)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 10)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 11)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            goal = Convert.ToInt32(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monthly_expenses, text2, text3, text4, text5,
                text6, text7, text8, text9, totaalExpenses;

            counter++;

            Expens expenses = new Expens();
            expenses.household = Convert.ToInt32(textBox2.Text);
            expenses.transport = Convert.ToInt32(textBox3.Text);
            expenses.finance = Convert.ToInt32(textBox4.Text);
            expenses.leisure = Convert.ToInt32(textBox5.Text);
            expenses.regularBills = Convert.ToInt32(textBox6.Text);
            expenses.insurance = Convert.ToInt32(textBox7.Text);
            expenses.children = Convert.ToInt32(textBox8.Text);
            expenses.otherBills = Convert.ToInt32(textBox9.Text);
            expenses.Id = ID;
            expenses.Month = comboBox1.Text;


            text2 = Convert.ToInt32(textBox2.Text);
            text3 = Convert.ToInt32(textBox3.Text);
            text4 = Convert.ToInt32(textBox4.Text);
            text5 = Convert.ToInt32(textBox5.Text);
            text6 = Convert.ToInt32(textBox6.Text);
            text7 = Convert.ToInt32(textBox7.Text);
            text8 = Convert.ToInt32(textBox8.Text);
            text9 = Convert.ToInt32(textBox9.Text);

            monthly_expenses = text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9;

            textBox10.Text = monthly_expenses.ToString();
            expenses.totalExpenses = Convert.ToInt32(textBox10.Text);

            budget.Expenses.Add(expenses);
            budget.SaveChanges();

            if (incomeclicked)
            {
                compare();
            }
            else
                expenseclicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int monthly_income, text1, text2, text3, text4, text5;
            counter++;

            Income income = new Income();
            income.netMonthIncome = Convert.ToInt32(textBox11.Text);
            income.pension = Convert.ToInt32(textBox12.Text);
            income.savingsIncome = Convert.ToInt32(textBox13.Text);
            income.otherIncome = Convert.ToInt32(textBox14.Text);
            income.Id = ID;
            text1 = Convert.ToInt32(textBox11.Text);
            text2 = Convert.ToInt32(textBox12.Text);
            text3 = Convert.ToInt32(textBox13.Text);
            text4 = Convert.ToInt32(textBox14.Text);

            monthly_income = text1 + text2 + text3 + text4;
            textBox15.Text = monthly_income.ToString();


            income.totalIncome = Convert.ToInt32(textBox15.Text);

            budget.Incomes.Add(income);
            budget.SaveChanges();


            Account account = new Account();

            account.Id = 0;
            account.Name = "Ant";
            account.Cash = Convert.ToInt32(textBox15.Text);
            account.Credit_Cards = 0;
            account.Bank = 0;
            account.investment = 0;

            budget.Accounts.Add(account);
            budget.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expensesDataGrid expenseDataView = new expensesDataGrid();
            expenseDataView.LoadInfo(Name, ID);
            expenseDataView.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            incomeDataGrid incomeDataView = new incomeDataGrid();
            incomeDataView.LoadInfo(Name, ID);
            incomeDataView.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (expenseclicked)
            {
                compare();
            }
            else
                incomeclicked = true;
        }

        private void compare()
        {
            if (Convert.ToInt32(textBox15.Text) - Convert.ToInt32(textBox10.Text) > goal)
            {
                MessageBox.Show("you have exceeded the set goal");
            }
            else
                MessageBox.Show("ypu have succeded in staying within your goal");

        }
    }
}
