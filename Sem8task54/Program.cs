// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
Console.Write(msg);
return int.Parse(Console.ReadLine() ?? "0");
}
// Генераци двумерного массива, заполненного случайными целыми значениями.
int[,] CreateRandomMatrix(int countRow, int countCol)
{
Random random = new Random();
int[,] matrix = new int[countRow, countCol];

for (int i = 0; i < countRow; i++)
{
for (int j = 0; j < countCol; j++)
{
matrix[i, j] = random.Next(1, 10);
}
}
return matrix;
}

//Сортировка строк
int[,] SortMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int k = 0; k < matrix.GetLength(1)-1; k++)
    {
    
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
        if (matrix[i,j+1] > matrix[i,j])
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[i,j+1];
            matrix[i,j+1] = temp;
        }

    }
    }
}
return matrix;
}

void Print2DArray(int[,] matrix)
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

int[,] userMatrix = CreateRandomMatrix(countRow, countCol);
Print2DArray(userMatrix);
Console.WriteLine();
SortMatrix(userMatrix);
Print2DArray(userMatrix);
