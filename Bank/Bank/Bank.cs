using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{ 
    class Bank
    {
        public void menuScreen()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
        }

        public void screeen1(List<Client> clients)
        {
            Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");
            clients.ForEach(c => Console.WriteLine(c.id + " | " + c.firstName + " | " + c.lastName + " | " + c.accountNumber + " | " + c.amount));
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");

         
        }



    }
}
