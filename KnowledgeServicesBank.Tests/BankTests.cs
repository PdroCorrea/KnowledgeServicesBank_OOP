using KnowledgeServicesBank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace KnowledgeServiceBand.Tests
{
    [ExcludeFromCodeCoverage]
    public class BankTests
    {
        [Test]
        public void WhenGivingANameToBankNameShouldBeTheSame()
        {
            //arrange
            var bankName = "Bank of Knowledge";
            var bank = new Bank(bankName);

            //act 

            // assert
            Assert.IsTrue(bank.Name.Equals(bankName));
        }

        [Test]
        public void WhenAddingMoreAccountsToBankTheListReturnsTheCorrectAmountOfAccounts()
        {
            //arrange
            var bankName = "Bank of Knowledge";
            var bank = new Bank(bankName);
            var listOfAccounts = new List<Account>() { new Account("John"), new Account("Smith") };

            //act 
            bank.Accounts = listOfAccounts;

            // assert
            Assert.IsTrue(bank.Accounts.Count == 2);
        }
    }
}
