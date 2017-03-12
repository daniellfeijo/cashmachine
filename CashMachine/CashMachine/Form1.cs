using CashMachine.Exceptions;
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
        List<Account> accounts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accounts = new List<Account>();
            Client client1 = new Client("Daniel");
            Account c1 = new CheckingAccount(client1);
            c1.Client = client1;
            c1.Number = 1;
            c1.Deposit(300);
            accounts.Add(c1);
            Client client2 = new Client("Eduardo");
            Account c2 = new CheckingAccount(client2);
            c2.Client = client2;
            c2.Number = 2;
            accounts.Add(c2);

            foreach(Account account in accounts)
            {
                AccountCombo.Items.Add(account.ToString());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int indexSelected = AccountCombo.SelectedIndex;
            Account account = accounts[indexSelected];

            try
            {
                account.Withdraw(Convert.ToDouble(WithdrawTextBox.Text));
                MessageBox.Show("Success!");
                BalanceText.Text = Convert.ToString(account.Balance);
                WithdrawTextBox.Text = "";
            } catch (BalanceNotEnoughException exception)
            {
                MessageBox.Show("Balance is not enough!");
            }catch (ArgumentException exception)
            {
                MessageBox.Show("Invalid value!");
            }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
            AccountCombo.Items.Add(account);
            MessageBox.Show("Account Added!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountRegistration registration = new AccountRegistration(this);
            registration.ShowDialog();
        }
    }
}
