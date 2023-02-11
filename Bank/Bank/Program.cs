using BankApp;
using System;


List<Client> clients = Client.CreateUsers();
List<String> accountNumbers = clients.Select(c => c.accountNumber).ToList();
Bank bank = new Bank();
Message message = new Message();
int choise;
string choiseStr;
message.MenuScreen();

while (true)
{
    choiseStr = Console.ReadLine();

    if (bank.IsCoorectKey(choiseStr, 3))
    {
        choise = int.Parse(choiseStr);

        if (choise == 1)
        {
            message.Screen1(clients);
            message.MenuScreen();
        }
        else if (choise == 2)
        {
            message.Screen2();
            string id = Console.ReadLine();
            if (bank.IsCoorectKey(id, clients.Count))
            { Client from = clients.FirstOrDefault(c => c.id == int.Parse(id));
                message.ShowClient(from);
                string choiseAccountNum = Console.ReadLine();
                if (accountNumbers.Contains(choiseAccountNum))
                {
                    Client to = clients.FirstOrDefault(c => c.accountNumber.Equals(choiseAccountNum));

                    if(from == to)
                    {
                        message.CantTransferToYourOwnAccount();
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("PODAJ KWOTĘ PRZELEWU: ");
                    string amount = Console.ReadLine();
                    decimal a;
                    if(decimal.TryParse(amount, out a))
                    {
                        if(from.amount < a)
                        {
                            message.ToMuch();
                            break;
                        }
                        bank.makeTransaction(from, to, a);
                        message.Screen1(clients);
                    }
                    else
                    {
                        message.WrongAmount();
                        break;
                    }
                    
                }
                else
                {
                    message.WrongAccountNum();
                    break;
                }

            }
            else
            {
                message.WrongId();
                break;
            }


        }
        else if (choise == 3)
        {
            break;
        }
    }
    else
    {
        Console.Clear();
        message.MenuScreen();
    }
    }

