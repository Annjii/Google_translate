using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppsconceps
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myCheckingAccount = new CheckingAccount();
            Savingsaccount mySavingsaccount = new SavingsAccount();

            byte accountSelection;
            byte actionSelection;

            do
            {
                Console.WriteLine("Welcome! Please make a selection");
                Console.WriteLine("1 - Checking Account");
                Console.WriteLine("2 - savings Account");
                Console.WriteLine("3 - Checking Balance");
                actionSelection = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                if(accountSelection !=3)
                {
                    do
                    {
                        Console.WriteLine("1 - Depodit");
                        Console.WriteLine("2 - Checking Account");
                        Console.WriteLine("3 -")

                    }
                }
            }
        }
    }
}
