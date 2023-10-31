using MoneyTransfer;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace MoneyTransferTests
{
    [TestClass]
    public class AcceptMoneyTests
    {
        [TestMethod]
        public void AcceptingAPositiveNumberWillIncreaseTheMoneyInThePersonsWallet()
      
        {

            //Arrange
            Person AcceptingMoney;
            AcceptingMoney= new Person("name",1);


            //Act
            AcceptingMoney.AcceptMoney(1);

            //Assert
            Assert.AreEqual(2, AcceptingMoney.wallet.money);
        }

        [TestMethod]
        public void AcceptingANegativeNumberWilldecreaseTheMoneyInThePersonsWallet()
        {
            //Arrange
            Person AcceptingMoney;
            AcceptingMoney= new Person("name", 1);
            //Act
            AcceptingMoney.AcceptMoney(-1);
            //Assert
            Assert.AreEqual(0, AcceptingMoney.wallet.money);
        }

        [TestMethod]
        public void AcceptingZeroShouldNotChangeTheMoneyInTheWallet()
        {
            //Arrange
            Person AcceptingMoney;
            AcceptingMoney=new Person("name", 1);
            //Act
            AcceptingMoney.AcceptMoney(0);
            //Assert
            Assert.AreEqual(1, AcceptingMoney.wallet.money);
        }



    }
}