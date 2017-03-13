using CashMachine;
using CashMachine.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachineTest.Model.Account
{
    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void ToStringTest()
        {
            CheckingAccount account = new CheckingAccount();
            account.Number = 123;
            Client client = new Client();
            client.Name = "Daniel";
            account.Client = client;

            Assert.AreEqual("123 - Daniel", account.ToString());
        }
    }
}
