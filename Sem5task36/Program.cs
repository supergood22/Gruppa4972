// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю

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

//Подсчет чисел на нечетных позициях
int CountOddPosition (int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        count+=arr[i];
    }
    return count;
}


int[] array = GenArray(5,0,21);
PrintArray(array);
int countRes = CountOddPosition(array);
Console.WriteLine("Сумма чисел на нечетных позициях: " + countRes);