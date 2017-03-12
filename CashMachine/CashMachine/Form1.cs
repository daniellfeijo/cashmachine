using CashMachine.DAO;
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
        IList<Account> accounts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            EntitiesContext context = new EntitiesContext();

            AccountDAO accountDao = new AccountDAO(context);
            accounts = accountDao.ListAll();

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
                EntitiesContext context = new EntitiesContext();
                AccountDAO accountDAO = new AccountDAO(context);
                Account accountDb = accountDAO.FindById(account.ID);
                accountDb.Withdraw(Convert.ToDouble(WithdrawTextBox.Text));
                accountDAO.SaveChanges();
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
