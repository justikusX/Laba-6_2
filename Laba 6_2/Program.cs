using System;
using MatrixLibrary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов (m):");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[] resultColumn = MatrixOperations.GetColumnWithMinSum(matrix);
        Console.WriteLine("Столбец с минимальной суммой элементов:");
        foreach (var item in resultColumn)
        {
            Console.WriteLine(item);
        }
    }
}