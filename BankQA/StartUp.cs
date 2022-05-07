using System;

namespace BankQA
{
    class StartUp
    {
        private const string DEPOSIT_MESSAGE = "Enter deposit value: ";
        static void Main(string[] args)
        {
            decimal balance = 0;
            Console.Write(DEPOSIT_MESSAGE);
            decimal deposit = decimal.Parse(Console.ReadLine());

            while (deposit < 0)
            {
                Console.WriteLine("You cannot add negative money");
                Console.Write(DEPOSIT_MESSAGE);
                deposit = decimal.Parse(Console.ReadLine());
                
            }
            
            
                balance += deposit;
                Console.WriteLine($"You deposited {balance} $");
            
            


        }
    }
}
