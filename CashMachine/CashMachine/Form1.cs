using CashMachine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public partial class Form1 : Form
    {
        Account[] accounts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accounts = new Account[2];
            accounts[0] = new CheckingAccount();
            Client client1 = new Client("Daniel");
            accounts[0].Client = client1;
            accounts[0].Number = 1;
            accounts[1] = new SavingsAccount();
            Client client2 = new Client("Eduardo");
            accounts[1].Client = client2;
            accounts[1].Number = 2;

            foreach(Account account in accounts)
            {
                AccountCombo.Items.Add(account.Client.Name);
            }
            


        }

        private void AccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = AccountCombo.SelectedIndex;
            Account account = accounts[indexSelected];

            ClientText.Text = account.Client.Name;
            NumberText.Text = Convert.ToString(account.Number);
            BalanceText.Text = Convert.ToString(account.Balance);


        }
    }
}
