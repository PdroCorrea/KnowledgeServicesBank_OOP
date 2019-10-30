using KnowledgeServicesBank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace KnowledgeServiceBand.Tests
{
    [ExcludeFromCodeCoverage]
    public class SavingsAccountTests
    {
        [Test]
        public void WhenDepositingAmountBalanceIncreasesByTheSameAmount()
        {
            //arrange
            var accountOwner = "John Doe";
            var account = new SavingsAccount(accountOwner);

            //act 
            account.Deposit(10);

            // assert
            Assert.IsTrue(account.Owner == accountOwner);
            Assert.That(account.Balance, Is.EqualTo(10));
        }
    }
}
