using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.DAO
{
    class ClientDAO
    {
        private EntitiesContext context;

        public ClientDAO(EntitiesContext context)
        {
            this.context = context;
        }

        public void save(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
        }
    }
}
