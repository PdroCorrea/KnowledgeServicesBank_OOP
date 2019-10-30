using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace KnowledgeServicesBank
{
    public class IndividualCheckingAccount : CheckingAccount
    {
        private readonly decimal withdrawLimit = 1000;
        public IndividualCheckingAccount(string owner) : base(owner)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > withdrawLimit)
            {
                throw new WithdrawLimitExceededException();
            }
            base.Withdraw(amount);
        }
    }

    [Serializable]
    [ExcludeFromCodeCoverage]
    public class WithdrawLimitExceededException : Exception
    {
       
        public WithdrawLimitExceededException(string message = "Witdraw limit exceeded.") : base(message)
        {
        }
    }
}
