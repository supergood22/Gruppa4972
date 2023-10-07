// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadData(string msg) // вводим данные
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}
// Формирование строки с числами
int SearchForNaturalElementsRec (int m, int n)
{
    int sum = 0;
 if (n >= m)
 {
    sum = m + SearchForNaturalElementsRec(m + 1, n);
 } 
 return sum;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

Console.WriteLine(SearchForNaturalElementsRec(m, n));