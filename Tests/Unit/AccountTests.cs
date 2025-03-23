using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H3_ATM.Entities;
using H3_ATM.Factories;
using H3_ATM.Interfaces.Repositories;
using H3_ATM.Repositories;
using H3_ATM.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H3_ATM.Tests.Unit
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            Account account = AccountFactory.Create(initialBalance: 1000);
            decimal depositAmount = 500;
            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(1500, account.Balance);
        }

        [TestMethod]
        public void Deposit_ShouldThrowException_WhenAmountIsZeroOrNegative()
        {
            // Arrange
            Account account = AccountFactory.Create();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(0));
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(-1));
        }

        [TestMethod]
        public void Withdraw_ShouldDecreaseBalance()
        {
            // Arrange
            Account account = AccountFactory.Create();

            // Act
            account.Withdraw(500);

            // Assert
            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
        {
            // Arrange
            Account account = AccountFactory.Create();

            // Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => account.Withdraw(1500));
        }

        [TestMethod]
        public void Withdraw_ShouldThrowException_WhenAmountIsZeroOrNegative()
        {
            // Arrange
            Account account = AccountFactory.Create();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(0));
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(-1));
        }
    }
}