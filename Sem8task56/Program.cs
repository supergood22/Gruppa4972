// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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

//Вывод массива
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

//подсчет суммы в строке и сохранение индекса минимальной суммы
int FindMinRow(int[,] matrix)
{
int index = 0;    
int minSum = 0;
int tempSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
//    Console.WriteLine(i);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
//        Console.Write(j + "\t");
        tempSum +=matrix[i, j];

    }
    //Console.WriteLine();
    //Console.WriteLine("tempSum="+tempSum);
    if (i == 0)
    {
        minSum = tempSum;
        index = i;
    //    Console.WriteLine(minSum);
    }
    if (tempSum < minSum)
    {
        minSum = tempSum;
    //    Console.WriteLine("+"+minSum);
        index = i;
    }
    tempSum = 0;
}
return index+1;
}

int[,] userMatrix = CreateRandomMatrix(countRow, countCol);
Print2DArray(userMatrix);
int res = FindMinRow(userMatrix);
//FindMinRow(userMatrix);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + res);