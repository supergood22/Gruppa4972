System.Console.WriteLine("Введите число:");
int numb1 = Convert.ToInt32(Console.ReadLine());

int checkNum = numb1 % 2;
if (checkNum == 1)
{
    System.Console.WriteLine("Число не четное");
}
else
{
    System.Console.WriteLine("Число четное");
}