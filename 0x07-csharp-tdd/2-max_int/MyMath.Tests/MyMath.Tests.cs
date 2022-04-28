using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MaxNum()
        {
            var array = new int[] { 5, 6, 500000, 87, 71, 3,-500, 50000, 2 };
            var myList = new List<int>(array);
            int result = Operations.Max(myList);
            Assert.AreEqual(500000, result);
        }

        [Test]
        public void IsEmpty()
        {
            var myList = new List<int>();
            int result = Operations.Max(myList);
            Assert.AreEqual(0, result);
        }
    }
}