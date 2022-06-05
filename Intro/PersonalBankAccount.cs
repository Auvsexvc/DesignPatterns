using System;

namespace Intro
{
    public class PersonalBankAccount : BankAccount
    {
        public void RequestPersonalLoan()
        {
            Console.WriteLine("Making request");
        }

        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Personal bank withdrawal");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }
            if (balance - amount < 0)
            {
                throw new Exception("Personal account cant go in debt");
            }
            balance -= amount;
        }
    }
}