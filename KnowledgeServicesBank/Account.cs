using System;

namespace KnowledgeServicesBank
{
    public class Account
    {
        public string Owner { get; }

        public decimal Balance { get; private set; }
        public Account(string owner)
        {
            Owner = owner;
            Balance = decimal.Zero;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException();
            }
            if (Balance < amount)
            {
                throw new OutOfFundException();
            }

            Balance -= amount;
        }
        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException();
            }
            Balance += amount;
        }
        public virtual void Transfer(Account destinationAcount, decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException();
            }
            Withdraw(amount);
            destinationAcount.Deposit(amount);
        }

    }

    [Serializable]
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message = "Value must be positive") : base(message)
        {
        }
    }
}
