using KnowledgeServicesBank;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace KnowledgeServiceBand.Tests
{
    [ExcludeFromCodeCoverage]
    public class IndividualCheckingAccountTests
    {
        [Test]
        public void WhenWithdrawingFromIndividualCheckingAccountCanWithdrwanValueBellowLimit()
        {
            //arrange
            var account = new IndividualCheckingAccount("John Doe");
            account.Deposit(10_000);

            //act
            account.Withdraw(999.99m);
            //act / assert
            Assert.That(account.Balance, Is.EqualTo(9_000.01m));
        }

        [Test]
        public void WhenWithdrawingFromIndividualCheckingAccountCanWithdrwanValueEqualLimit()
        {
            //arrange
            var account = new IndividualCheckingAccount("John Doe");
            account.Deposit(10_000);

            //act
            account.Withdraw(1_000);

            //act 
            Assert.That(account.Balance, Is.EqualTo(9_000));
        }

        [Test]
        public void WhenWithdrawingFromIndividualCheckingAccountCannotWithdrwanValueAboveLimit()
        {
            //arrange
            var account = new IndividualCheckingAccount("John Doe");
            account.Deposit(10_000);

            //act / assert
            Assert.That(() => account.Withdraw(1_000.01m), Throws.InstanceOf<WithdrawLimitExceededException>());
        }
    }
}
