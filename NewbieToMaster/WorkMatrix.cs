using System;

namespace NewbieToMaster;

public static class WorkMatrix
{
    public static void Task2()
    {
        string[] size = Console.ReadLine()!.Split(' ');
        int m = Convert.ToInt32(size[0]);
        int n = Convert.ToInt32(size[1]);

        int[,] matrix = new int[n, n];

        for (int i = 0; i < m; i++)
        {
            string[] dataRow = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Convert.ToInt32(dataRow[j]);
            }
        }

        // Find max value
        int max = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }

        Console.WriteLine(max);
    }
}