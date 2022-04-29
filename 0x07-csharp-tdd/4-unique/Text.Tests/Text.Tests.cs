using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [TestCase("hello", ExpectedResult=0)]
        [TestCase("abecedario", ExpectedResult = 1)]
        [TestCase("hello", ExpectedResult = 0)]
        [TestCase("hello", ExpectedResult = 0)]
        [TestCase("hello", ExpectedResult = 0)]
        public int FirstChar(string str)
        {
            int index = Str.UniqueChar(str);
            return index;
        }
    }
}