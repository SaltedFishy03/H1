using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private double Balance { get; set; }
        public void WithDraw(double amount)
        {
            if (Balance > amount)
            {

                Balance = Balance - amount;
            }
            else
                Console.WriteLine("There is not enough money on your bank account");
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public double GetBalance()
        {
            return Balance;
        }


    }
}
