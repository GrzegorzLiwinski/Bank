using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Message
    {
        public void MenuScreen()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3: ");

        }

        public void Screen1(List<Client> clients)
        {
            Console.Clear();
            Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");
            clients.ForEach(c => Console.WriteLine(c.id + " | " + c.firstName + " | " + c.lastName + " | " + c.accountNumber + " | " + c.amount));
        }

        public void Screen2()
        {
            Console.Clear();
            Console.WriteLine("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA: ");
        }

        public void WrongAccountNum()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WrongId()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LOGOWANIE NIEUDANE");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public  void ShowClient(Client client)
        {
            Console.WriteLine("ZALOGOWANY KLIENT");
            Console.WriteLine("ID: " + client.id);
            Console.WriteLine("IMIĘ I NAZWISKO: " + client.firstName + " " + client.lastName);
            Console.WriteLine("NR KONTA: " + client.accountNumber);
            Console.WriteLine("SALDO: " + client.amount + " zł");
            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW: ");
        }

        public void WrongAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWA KWOTA");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ToMuch()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CantTransferToYourOwnAccount()
        {
            Console.Clear();    
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIE MOŻESZ ZROBIĆ PRZELEWU NA WŁASNE KONTO.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
