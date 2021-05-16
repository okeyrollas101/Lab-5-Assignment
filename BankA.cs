using System;

namespace Lab_5_Assignment
{
    public class BankA : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("Availiable balance in BankA: $100");
        }
    }
}