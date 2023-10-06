// Задача 58: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int userSize = ReadInt("Введите размер матрицы m (m x m): ");

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
Console.Write(msg);
return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными целыми значениями.
int[,] CreateRandomMatrix(int size)
{
Random random = new Random();
int[,] matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
for (int j = 0; j < size; j++)
{
matrix[i, j] = random.Next(1, 10);
}
}
return matrix;
}

void Print2DArray(int[,] firstMatrix, int[,] secondMatrix)
{
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
for (int j = 0; j < firstMatrix.GetLength(1); j++)
{
    Console.Write(firstMatrix[i,j]+" ");

}
Console.Write("| ");
for (int j = 0; j < secondMatrix.GetLength(1); j++)
{
    Console.Write(secondMatrix[i,j]+" ");

}
Console.WriteLine();
}
}

int[,] multiplicationOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] res = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    int tempSum = 0;
    
    for(int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        //int count = 0;
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                tempSum += firstMatrix[i, j] * secondMatrix[j, k];

            }
            res[i, k] = tempSum;
           // count += 1;
            tempSum = 0;
        }
    }
    return res;
}

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{

Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}
}

int[,] firstMatrix = CreateRandomMatrix(userSize);
int[,] secondMatrix = CreateRandomMatrix(userSize);
Print2DArray(firstMatrix, secondMatrix);
int[,] userRes = multiplicationOfMatrix(firstMatrix, secondMatrix);
PrintArray(userRes);
