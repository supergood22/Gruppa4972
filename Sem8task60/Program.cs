// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int userLength = ReadInt("Введите длину матрицы l: ");
int userHeight = ReadInt("Введите высоту матрицы h: ");
int userWidth = ReadInt("Введите ширину матрицы  w: ");


// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
Console.Write(msg);
return int.Parse(Console.ReadLine() ?? "0");
}

int[] arr = new int[90];
for (int i = 10; i <100; i++)
{
    arr[i-10] = i;
}

int[,,] fill3DArr(int height, int width, int length, int[] array)
{
    Random rnd = new Random();
    int[,,] res = new int[length, height, width];

    int index;
    for (int k = 0; k < length; k++)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                index = rnd.Next(0, 91);
                Console.WriteLine(index);
                Console.WriteLine(array.Length);
                int[] newArr = new int[array.Length - 1];
                for (int m = 0; m < index; m++)
                {
                    newArr[m] = array[m];
                }
                for (int m = index + 1; m < array.Length; m++)
                {
                    newArr[m -1] = array[m];
                }
                array = newArr;
                res[k,i,j] = index;
            }
        }
    }
    return res;

}

int[,,] user3DArr =  fill3DArr(userLength, userHeight, userWidth, arr);

// Вывод двумерного массива на экран.
void Print3DMatrix(int[,,] matrix)
{
Console.WriteLine("\n");

int lengthCount = matrix.GetLength(0);
int heightCount = matrix.GetLength(1);
int widtCount = matrix.GetLength(2);

for (int k = 0; k < lengthCount; k++)
{
    for (int i = 0; i < heightCount; i++)
    {
        for (int j = 0; j < widtCount; j++)
        {
            Console.Write($"{matrix[k, i, j]}({k},{i},{j})" + "\t" );
        }
        Console.WriteLine();
    }
}
}

Print3DMatrix(user3DArr);