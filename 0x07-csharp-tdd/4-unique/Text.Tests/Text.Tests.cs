using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [TestCase("hello", ExpectedResult=0)]
        [TestCase("ok", ExpectedResult = 0)]
        [TestCase("freddy", ExpectedResult = 0)]
        [TestCase("aaeeiioouu", ExpectedResult = -1)]
        public int FirstChar(string str)
        {
            int index = Str.UniqueChar(str);
            return index;
        }
    }
}