using KnowledgeServicesBank;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace KnowledgeServiceBand.Tests
{
    [ExcludeFromCodeCoverage]
    public class ActionsTests
    {

        [Test]
        public void WhenDepositingAmountValueCannotBeNegative()
        {
            //arrange
            var account = new Account("John Doe");

            //act / assert
            Assert.That(() => account.Deposit(-1), Throws.InstanceOf<InvalidAmountException>());
        }

        [Test]
        public void WhenDepositingAmountBalanceIncreasesByTheSameAmount()
        {
            //arrange
            var accountOwner = "John Doe";
            var account = new Account(accountOwner);

            //act 
            account.Deposit(10);

            // assert
            Assert.IsTrue(account.Owner == accountOwner);
            Assert.That(account.Balance, Is.EqualTo(10));
        }

        [Test]
        public void WhenDepositingAmountManyTimesTheBalanceShouldShowTheSumOfTheDeposits()
        {
            //arrange
            var account = new Account("John Doe");

            //act 
            account.Deposit(10);
            account.Deposit(5);
            account.Deposit(15);
            // assert
            Assert.That(account.Balance, Is.EqualTo(30));
        }

        [Test]
        public void WhenWithdrawingAmountValueCannotBeNegative()
        {
            //arrange
            var account = new Account("John Doe");

            //act / assert
            Assert.That(() => account.Withdraw(-1), Throws.InstanceOf<InvalidAmountException>());
        }

        [Test]
        public void WhenWithdrawingAmountValueDecreasesByTheSameValue()
        {
            //arrange
            var account = new Account("John Doe");
            account.Deposit(10);
            //act 
            account.Withdraw(5);

            //assert
            Assert.That(account.Balance, Is.EqualTo(5));
        }

        [Test]
        public void WhenWithdrawingAmountValueCannotBeBiggerThanBalance()
        {
            //arrange
            var account = new Account("John Doe");
            account.Deposit(10);
            //act / assert
            Assert.That(() => account.Withdraw(10.01m), Throws.InstanceOf<OutOfFundException>());
        }
        [Test]
        public void WhenTransferingAccounAshouldReduceTheBalanceAndAccounBshouldIncreaseBasedOnGivingAmount()
        {
            //arrange
            var accountA = new Account("John Doe");
            var accountB = new Account("Agent Smith");
            accountA.Deposit(20);
            //act 
            decimal amount = 10m;
            accountA.Transfer(accountB, amount);

            // assert
            Assert.IsTrue(accountA.Balance == 10);
            Assert.IsTrue(accountB.Balance == 10);
        }
        [Test]
        public void WhenTryingToTransferANegativValueItShouldNotBeAllowed()
        {
            //arrange
            var account = new Account("John Doe");

            //act / assert
            Assert.That(() => account.Transfer(new Account("Agent Smith") ,- 1), Throws.InstanceOf<InvalidAmountException>());
        }

    }
}
