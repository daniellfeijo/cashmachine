using CashMachine.DAO;
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
    public partial class AccountRegistration : Form
    {
        private Form1 mainApplication;

        public AccountRegistration(Form1 mainApplication)
        {
            this.mainApplication = mainApplication;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameClient = clientNameTextBox.Text;
            int accountNumber = Convert.ToInt32(accountNumberTextBox.Text);

            EntitiesContext context = new EntitiesContext();

            Client client = new Client(nameClient);
            ClientDAO clientDAO = new ClientDAO(context);
            clientDAO.save(client);

            Account account = new CheckingAccount(client);
            account.Number = accountNumber;
            AccountDAO accountDAO = new AccountDAO(context);
            accountDAO.save(account);

            context.Dispose();


            this.mainApplication.AddAccount(account);

            clientNameTextBox.Text = "";
            accountNumberTextBox.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
