﻿using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();

    }

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] array2D = new int[n, m];
      int temp = 1;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          array2D[i,j] = temp;
          temp = temp + k;
        }
    }

    return array2D;
    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
      Console.Write(list[i].ToString("0.00") + "\t");
    }
    
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
      double[] averageInCol = new double[matrix.GetLength(1)];
      for (int j=0; j < matrix.GetLength(1); j++)
      {
        double mgl = matrix.GetLength(0);
        double sum = 0.00;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        averageInCol[j] = Math.Round(sum / matrix.GetLength(0), 2);
      }
      return averageInCol;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}