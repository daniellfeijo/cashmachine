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
            accounts[0].Deposit(300);
            accounts[1] = new CheckingAccount();
            Client client2 = new Client("Eduardo");
            accounts[1].Client = client2;
            accounts[1].Number = 2;

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
    }
}
