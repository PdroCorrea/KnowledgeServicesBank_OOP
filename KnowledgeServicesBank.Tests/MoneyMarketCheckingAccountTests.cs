using KnowledgeServicesBank;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace KnowledgeServiceBand.Tests
{
    [ExcludeFromCodeCoverage]

    public class MoneyMarketCheckingAccountTests
    {
        [Test]
        public void WhenDepositingAmountBalanceIncreasesByTheSameAmount()
        {
            //arrange
            var accountOwner = "John Doe";
            var account = new MoneyMarketCheckingAccount(accountOwner);

            //act 
            account.Deposit(10);

            // assert
            Assert.IsTrue(account.Owner == accountOwner);
            Assert.That(account.Balance, Is.EqualTo(10));
        }
    }
}
