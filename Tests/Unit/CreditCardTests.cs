using System;
using H3_ATM.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H3_ATM.Tests.Unit
{
    [TestClass]
    public class CreditCardTests
    {
        [TestMethod]
        public void CreditCard_DefaultStatus_ShouldBeActive()
        {
            // Arrange & Act
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);

            // Assert
            Assert.AreEqual("Active", card.Status);
        }

        [TestMethod]
        public void Charge_ShouldIncreaseCurrentBalance_WhenAmountIsValid()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);
            decimal chargeAmount = 200m;

            // Act
            card.Charge(chargeAmount);

            // Assert
            Assert.AreEqual(700m, card.CurrentBalance);
        }

        [TestMethod]
        public void Charge_ShouldThrowException_WhenAmountIsZeroOrNegative()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);

            // Act & Assert for zero amount
            var ex = Assert.ThrowsException<InvalidOperationException>(() => card.Charge(0));
            Assert.AreEqual("Charge amount must be greater than zero.", ex.Message);

            // Act & Assert for negative amount
            ex = Assert.ThrowsException<InvalidOperationException>(() => card.Charge(-50));
            Assert.AreEqual("Charge amount must be greater than zero.", ex.Message);
        }

        [TestMethod]
        public void Charge_ShouldThrowException_WhenCardIsLocked()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);
            card.LockCard();
            
            // Act & Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => card.Charge(100));
            Assert.AreEqual("Cannot charge a locked card.", ex.Message);
        }

        [TestMethod]
        public void MakePayment_ShouldDecreaseCurrentBalance_WhenAmountIsValid()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);
            decimal paymentAmount = 150m;

            // Act
            card.MakePayment(paymentAmount);

            // Assert
            Assert.AreEqual(350m, card.CurrentBalance);
        }

        [TestMethod]
        public void MakePayment_ShouldThrowException_WhenAmountIsZeroOrNegative()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);

            // Act & Assert for zero amount
            Exception ex = Assert.ThrowsException<InvalidOperationException>(() => card.MakePayment(0));
            Assert.AreEqual("Payment amount must be greater than zero.", ex.Message);

            // Act & Assert for negative amount
            ex = Assert.ThrowsException<InvalidOperationException>(() => card.MakePayment(-25));
            Assert.AreEqual("Payment amount must be greater than zero.", ex.Message);
        }

        [TestMethod]
        public void MakePayment_ShouldThrowException_WhenCardIsLocked()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);
            card.LockCard();
            
            // Act & Assert
            Exception ex = Assert.ThrowsException<InvalidOperationException>(() => card.MakePayment(100));
            Assert.AreEqual("Cannot make payment on a locked card.", ex.Message);
        }

        [TestMethod]
        public void LockCard_ShouldSetStatusToLocked()
        {
            // Arrange
            CreditCard card = new CreditCard("John Doe", "1234-5678-9012-3456", 1234, 500m);

            // Act
            card.LockCard();

            // Assert
            Assert.AreEqual("Locked", card.Status);
        }
    }
}
