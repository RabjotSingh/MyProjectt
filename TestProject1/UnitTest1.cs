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

    }
}