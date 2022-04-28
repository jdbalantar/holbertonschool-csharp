using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("HOH")]
        [TestCase("ada")]
        [TestCase("Ana")]
        [TestCase("Alla")]
        [TestCase("Ata")]
        [TestCase("aM  a")]
        [TestCase("Os o")]
        [TestCase("Ar epera")]
        [TestCase("oR  O")]
        [TestCase("rA yAr")]
        [TestCase("SaLaS")]
        [TestCase("sErES")]
        [TestCase(" ")]
        [TestCase("    ")]
        [TestCase(" / ")]
        [TestCase(" * * * ")]
        [TestCase("A man, a plan, a canal: Panama.")]
        public void IsPalindrome(string value)
        {
            bool result = Str.IsPalindrome(value);
            Assert.IsTrue(result);
        }

        [TestCase("Hola")]
        [TestCase("Alo")]
        [TestCase("Querer")]
        [TestCase("Oye")]
        [TestCase("Hello")]
        [TestCase("WorLd")]
        [TestCase("Word")]
        public void NoIsPalindrome(string value)
        {
            bool result = Str.IsPalindrome(value);
            Assert.IsFalse(result);
        }

        [TestCase("")]
        public void IsVoid(string value)
        {
            bool result = Str.IsPalindrome(value);
            Assert.IsTrue(result);
        }


    }
}