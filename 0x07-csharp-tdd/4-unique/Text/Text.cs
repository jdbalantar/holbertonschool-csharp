using System;

namespace Text
{
    /// <summary>
    /// Class contains method UniequeChar
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method that return the first non-repeating character
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int UniqueChar(string s)
        {
            int size = s.Length, c = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (s[i] == s[j])
                        c++;
                }
                if (c == 1)
                    return i;
            }
            return -1;
        }
    }
}
