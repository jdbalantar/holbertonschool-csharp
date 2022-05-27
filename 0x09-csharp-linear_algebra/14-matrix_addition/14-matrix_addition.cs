﻿using System;
/// <summary>
/// Matrix Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] array = { { -1 } };
        if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
        {
            return array;
        }
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return array;
        }
        if (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3)
        {
            return (array);
        }
        double[,] AddMatrix = null;
        if (matrix1.GetLength(0) == 2)
        {
            AddMatrix = new double[2, 2];
        }
        else
        {
            AddMatrix = new double[3, 3];
        }
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                AddMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return (AddMatrix);
    }
}