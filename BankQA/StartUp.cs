using System;

namespace BankQA
{
    class StartUp
    {
        static void Main(string[] args)
        {
            decimal balance = 0;
            decimal deposit = decimal.Parse(Console.ReadLine());

            if (deposit < 0)
            {
                Console.WriteLine("You cannot add negative money");
                
            }
            else
            {
                balance += deposit;
                Console.WriteLine($"You deposited {balance} $");
            }
            


        }
    }
}
