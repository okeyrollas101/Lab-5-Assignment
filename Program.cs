using System;

namespace Lab_5_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Bank gtb = new BankA();
           gtb.getBalance();
           Bank fcmb = new BankB();
           fcmb.getBalance();
           Bank access = new BankC();
           access.getBalance();  
        }
    }
}
