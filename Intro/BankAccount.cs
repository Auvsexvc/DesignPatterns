using System;

namespace Intro
{
    public class BankAccount
    {
        protected float balance;

        public string Name { get; set; }

        public void MakeDeposit(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }
            balance += amount;
        }

        public virtual void MakeWithdrawal(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }
            balance -= amount;
        }

        public float GetBalance()
        {
            return balance;
        }
    }
}