using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        public BankAccount(int id, decimal balance = 0)
        {
            this.Id = id;
            this.Balance = balance;

        }

        public int Id { get; }
        public decimal Balance { get; }
        public void Deposit(decimal amount)
        {


            if (amount <= 0)
            {
                throw new InvalidOperationException("Negative amount")

    }
            this.Balance += amount;

        }
    }
}
