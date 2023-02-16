using NUnit.Framework;
using System;

namespace BankingSystem.Tests
{
    public class BankAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepositShouldIncreaseBalance()
        {
            {
                //Arrange
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = 100;

                //Act
                bankAccount.Deposit(depositAmount);

                //Assert 
                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
        }

        [Test]
        public void AccountInicialazeWithPositiveValue()
        {
            {
                //Arrange


                //Act
                BankAccount bankAccount = new BankAccount(123, 2000m);


                //Assert
                Assert.AreEqual(2000m, bankAccount.Balance);
            }
        }
        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExeptionsWithMessage()
        {
            {
                //Arrange
                BankAccount bankAccount = new BankAccount(123);
                decimal amountDeposit = -100;

                //Act

                //Assert
                var ex = Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(amountDeposit));
                Assert.AreEqual(ex.Message, "Negative amount");
            }
        }
        [Test]
        {
        public void ConstructorShouldSetZeroBalance;
        {
        //Arrange
        int id = 123;
        //Act
        BankAccount account = new BankAccount(id);
        //Assert
        Assert.AreEqual(0, account.Balace);
        }
}












