using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [TestCase("hello", ExpectedResult=0)]
        public int FirstChar(string value)
        {
            int index = Str.UniqueChar(value);
            return index;
        }
    }
}