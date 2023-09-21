// №38 Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, 
// а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.

//Заполняем одномерный массив
double[] GenArray(int num)
{

    double[] array = new double[num];

    for (int i = 0; i < num; i++)
    {
    array[i] = new Random().NextDouble()*100;
    }

    return array;
}

// Печатаем результат
void PrintArray(double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write(arr[i] + "; ");

}
Console.WriteLine(arr[arr.Length - 1] + "]");
}

double SubtractionOfMaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}


double[] array = GenArray(8);
PrintArray(array);
Console.WriteLine("Разница между max и min: " + SubtractionOfMaxMin(array));

//Console.WriteLine("Сумма чисел на нечетных позициях: " + countRes);

