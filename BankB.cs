using System;

namespace Lab_5_Assignment
{
    public class BankB : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("Availiable balance in BankB: $150");
        }
    }
}