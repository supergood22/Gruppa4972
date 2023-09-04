
Console.WriteLine("Введите число");

string? inputNum = Console.ReadLine();//??"0";

if(inputNum!=null)
{
    int num = int.Parse(inputNum);

    int res = num * num;

    Console.WriteLine(res);
}