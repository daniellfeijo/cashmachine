using CashMachine.Model;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.DAO
{
    class AccountDAO
    {
        private EntitiesContext context;

        public AccountDAO(EntitiesContext context)
        {
            this.context = context;
        }

        public void save(Account account)
        {
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public IList<Account> ListAll()
        {
            var research = from a in context.Accounts.Include(a=> a.Client ) select a;

            return research.ToList();
        }
    }
}
