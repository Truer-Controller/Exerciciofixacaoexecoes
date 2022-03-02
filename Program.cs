using Exerciciofixacaoexecoes.Entities;
using Exerciciofixacaoexecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exerciciofixacaoexecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string nameHolder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(numberAccount, nameHolder, initialBalance, withdrawLimit);

                Console.WriteLine("");
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(withdraw);

                Console.Write("New Balance: " + account.BalanceAccount.ToString("F2", CultureInfo.InvariantCulture));
            } 
            
            catch(DomainException e)
            {
                Console.WriteLine("Erro > " + e.Message);
            }
        }
    }
}
