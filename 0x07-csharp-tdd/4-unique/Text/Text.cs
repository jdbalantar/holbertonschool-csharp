using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            int size = s.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == size - 1)
                        return i;
                    if (j != i && s[i] == s[j])
                        break;
                }
            }
            return -1;
        }
    }
}
