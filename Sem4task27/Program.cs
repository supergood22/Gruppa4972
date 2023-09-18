// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

// Ввод числа из консоли
int readData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

// Вывод числа в консоль
void PrintResult(int resnum)
{
Console.WriteLine(resnum);
}

//Возведение в степень
int sumDigit(int a)
{
    int res = 0;
    while (a > 0)
    {
        int digit = a%10;
        res += digit;
        a /= 10;
    }
    return res;
}

int numA = readData("Введите число: ");
PrintResult(sumDigit(numA));