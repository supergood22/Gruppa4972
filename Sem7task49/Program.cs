//Вводим данные
int ReadData(string msg)
{
Console.WriteLine(msg);
int number = int.Parse(Console.ReadLine() ?? "0");
return number;
}

// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
System.Random rnd = new System.Random();
int[,] array2D = new int[countRow, countColumn];

for (int i = 0; i < countRow; i++)
{
for (int j = 0; j < countColumn; j++)
{
array2D[i, j] = rnd.Next(downBorder, topBorder);
}
}
return array2D;
}

void Update2DArray(int[,] mtrx)
{
for (int i = 0; i < mtrx.GetLength(0); i = i + 2)
{
for (int j = 0; j < mtrx.GetLength(1); j = j + 2)
{
mtrx[i, j] = mtrx[i, j] * mtrx[i, j];
}
}
}