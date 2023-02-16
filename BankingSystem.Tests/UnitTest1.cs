using NUnit.Framework;

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
        
    }
}