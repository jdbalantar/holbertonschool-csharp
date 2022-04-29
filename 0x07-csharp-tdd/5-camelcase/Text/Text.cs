using System;

namespace Text
{
    /// <summary>
    /// Class that contains CamelCase method
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method that return quantity words in a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CamelCase(string s)
        {
            int count = 0;
            for(int i = 1; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    count++;
            }
            return count;
        }
    }
}
