// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// (Задание со звездочкой) Пользователь вводит число нажатий, 
// затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// Вывод сообщения и запись введённых данных
int SizeArr(string message)
{
Console.Write(message);
string value = Console.ReadLine()??",";
int count = Convert.ToInt32(value);

return count;
}

// Ввод элементов массива
int[] MakeArr(int size)
{
    int[] arr = new int[size];
    int count = 0;
    while ( count <= size-1)
    {
        string elemStr = Console.ReadLine()??",";
        int elemInt = Convert.ToInt32(elemStr);
        arr[count] = elemInt;
        count += 1;
    }
    return arr;
}

// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
Console.Write(array[i] + ", ");
Console.WriteLine(array[array.Length - 1] + "]");
}

//Подсчет элементов больше нуля
int countPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count +=1;
        }
    }
    return count;
}


int size = SizeArr("Введите размер массива: ");
int[] userArr = MakeArr(size);
OutputArray(userArr);
Console.WriteLine("Количество элементов больше 0 в массиве: " + countPositive(userArr));