using System;

namespace Intro
{
    public class CompanyBankAccount : BankAccount
    {
        public void TakeLoan()
        {
            ///
        }

        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Make withdrawal for company bank account");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }
            balance -= amount;
        }
    }
}