using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp
{
    internal class Bank
    {

        public void makeTransaction(Client clientFrom, Client clientTo, decimal amount)
        {
            clientFrom.amount = clientFrom.amount - amount;
            clientTo.amount = clientTo.amount + amount;
        }


        public bool IsCoorectKey(string key, int range)
        {
            int.TryParse(key, out int number);
            if (number > 0 && number <= range)
                return true;

            return false;
        }

    }
}
