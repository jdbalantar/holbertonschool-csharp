using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// This class contains method that verify if a string is or not palindrome
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Return true if a string is palindrome, false else
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string s) {
            if (s.Length == 0) {
                return true;
            }
            else
            {
                string str = string.Empty;
                for (int i = s.Length - 1; i >= 0; i--)
                    str += s[i];
                str = Regex.Replace(str, @"[^\w]", "");
                s = Regex.Replace(s, @"[^\w]", "");
                if (str.ToUpper() == s.ToUpper())
                    return true;
                else
                    return false;
            }
        }
    }
}
