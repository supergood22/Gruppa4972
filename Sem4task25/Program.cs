// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

// Ввод числа из консоли
int readData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

// Вывод числа в консоль
void PrintResult(long resnum)
{
Console.WriteLine(resnum);
}

//Возведение в степень
long MyPow(int a, int b)
{
    long res = a;
    for (int i = 1; i < b; i++)
    {
        res *=a;

    }
    return res;
}

int numA = readData("Введите число А: ");
int numB = readData("Введите число B: ");
PrintResult(MyPow(numA, numB));