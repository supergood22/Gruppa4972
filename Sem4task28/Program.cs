﻿// Ввод числа из консоли
int readData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

// Вывод числа в консоль
void PrintResult(string mes)
{
Console.WriteLine(mes);
}


long FactorialNum(int num)
{
long fact=1;

for(int i=2; i<=num; i++)
{
fact*=i;
}
return fact;
}

int enterNum=readData("Введите число: ");
long result=FactorialNum(enterNum);

PrintResult($"Произведение чисел от 1 до {enterNum} = {result}");