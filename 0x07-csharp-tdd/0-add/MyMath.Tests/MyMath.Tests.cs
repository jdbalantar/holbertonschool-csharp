using NUnit.Framework;
using MyMath;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddTest()
        {
            int result = MyMath.Operations.Add(300,200);
            Assert.AreEqual(500, result);
        }
    }
}