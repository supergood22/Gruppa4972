// №34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder)
{

    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
    array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write(arr[i] + ", ");

}
Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Подсчет четных чисел
int CountEven (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) count+=1;
    }
    return count;
}


int[] array = GenArray(10,100,1000);
PrintArray(array);
int countRes = CountEven(array);
Console.WriteLine("Количество четных чисел: " + countRes);