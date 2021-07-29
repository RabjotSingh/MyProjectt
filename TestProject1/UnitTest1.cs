using NUnit.Framework;
using MyProject;

namespace TestProject1  
{
    [TestFixture]
    public class UnitTest1
    {

        Class1 myobject = new Class1();
        Banking myotherobject = new Banking();
        
        [Test]
        public void TestAdd()
        {
            int result = myobject.addition(5, 6);
            Assert.AreEqual(11, result);
        }

        [Test]
        public void TestAddd()
        {
            int result = myobject.addition(5, 6);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestTakeName()
        {
            string actual = myotherobject.TakeName();
            string expected = "Hello Rabjot";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDepositMoney()
        {
            int result = myotherobject.DepositMoney(10000);
            Assert.AreEqual(45000, result);
        }

        [Test]
        public void TestWithdrawMoney()
        {
            int result = myotherobject.WithdrawMoney(25000);
            Assert.AreEqual(10000, result);
        }
    }
}
