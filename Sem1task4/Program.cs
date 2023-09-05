System.Console.WriteLine("Введите три числа");
int numb1 = Convert.ToInt32(Console.ReadLine());
int numb2 = Convert.ToInt32(Console.ReadLine());
int numb3 = Convert.ToInt32(Console.ReadLine());
if (numb1 > numb2 && numb1 > numb3)
{
    System.Console.WriteLine("max = " + numb1);
}
else if (numb2 > numb1 && numb2 > numb3)
{
    System.Console.WriteLine("max = " + numb2);
}
else if (numb3 > numb2 && numb3 > numb1)
{
    System.Console.WriteLine("max = " + numb3);
}
