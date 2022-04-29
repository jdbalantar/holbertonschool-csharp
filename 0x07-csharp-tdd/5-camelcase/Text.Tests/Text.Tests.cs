using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [TestCase("HelloWorld", ExpectedResult = 1)]
        [TestCase("HowAreYou?", ExpectedResult = 2)]
        [TestCase("IAmStudentOfHolbertonSchool", ExpectedResult = 5)]
        [TestCase("IAmProggramer", ExpectedResult = 2)]
        public int IsUpper(string str)
        {
            int cant = Str.CamelCase(str);
            return cant;
        }
    }
}