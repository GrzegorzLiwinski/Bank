using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Client
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string accountNumber { get; set; }
        public decimal amount { get; set; }

        Client(int id, string firstName, string lastName, string accountNumber, decimal amount)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.accountNumber = accountNumber;
            this.amount = amount;
        }

        public List<Client> createUsers()
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client(1, "Jan", "Nowak", "001", 1457.23m));
            clients.Add(new Client(2, "Agnieszka", "Kowalska", "002", 3600.18m));
            clients.Add(new Client(3, "Robert", "Lewandowski", "003", 2745.03m));
            clients.Add(new Client(4, "Zofia", "Plucińska", "004", 7344.00m));
            clients.Add(new Client(5, "Grzegorz", "Braun", "005", 455.38m));
            return clients;
        }
    }
}
