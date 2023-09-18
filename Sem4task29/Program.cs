// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
// Console.WriteLine(message);
// string value = Console.ReadLine()??",";
// int number = Convert.ToInt32(value);

// return number;
// }
// Заполняет массив случайными цифрами
int[] RandomArray()
{
int[] randNums = new int[8];
for (int i = 0; i < 8; i++)
randNums[i] = new Random().Next(0, 10);
return randNums;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
Console.Write(array[i] + ",");
Console.Write(array[array.Length - 1] + "]");
}

int[] array = RandomArray();
OutputArray(array);