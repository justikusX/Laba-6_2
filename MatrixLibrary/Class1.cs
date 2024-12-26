using System;

namespace MatrixLibrary
{
    public class MatrixOperations
    {
        public static int[] GetColumnWithMinSum(int[,] matrix)
        {
            int columns = matrix.GetLength(1);
            int minSumIndex = -1;
            int minSum = int.MaxValue;

            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumIndex = j;
                }
            }

            int[] resultColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                resultColumn[i] = matrix[i, minSumIndex];
            }

            return resultColumn;
        }
    }
}