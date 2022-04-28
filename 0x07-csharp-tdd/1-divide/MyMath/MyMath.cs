using System;

namespace MyMath
{
    /// <summary>
    /// Class that contains math methods
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Math that return a matrix divided by the parameter num
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num >= 0)
            {
                if(matrix.GetLength(0) > 0 && matrix.GetLength(1) > 0)
                {
                    try
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                            for (int j = 0; j < matrix.GetLength(1); j++)
                                matrix[i, j] = matrix[i, j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Num cannot be 0");
                        return null;
                    }
                    return matrix;
                }
                else
                    return null;
            }
            return null;
        }
    }
}
