using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CorrectMatrix()
        {
            var matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            var result = Matrix.Divide(matrix, 2);
            var matrixDivided = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            CollectionAssert.AreEqual(matrixDivided, result);

        }

        [Test]
        public void ZeroValue()
        {
            var matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            var result = Matrix.Divide(matrix, 0);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void NegativeValue()
        {
            var matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            var result = Matrix.Divide(matrix, -5);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void VoidMatrix()
        {
            var matrix = new int[,] { };
            var result = Matrix.Divide(matrix, 10);
            Assert.AreEqual(null, result);
        }
    }
}