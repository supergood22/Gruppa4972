System.Console.WriteLine("Введите два числа");
int numb1 = Convert.ToInt32(Console.ReadLine());
int numb2 = Convert.ToInt32(Console.ReadLine());
if (numb1 == numb2)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    if (numb1 > numb2) 
    {
        System.Console.WriteLine("max = " + numb1);
    }
    else 
    {
    System.Console.WriteLine("max = " + numb2);
    }
}