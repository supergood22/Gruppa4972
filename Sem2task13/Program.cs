// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.WriteLine("Введите число от 1 до 999999999. Программа выведет 3-ю цифру, если она есть.");
int number = int.Parse(Console.ReadLine()??"0");
int numberFirth = 0;
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 99)
    {
        numberFirth = number%10;
        number /= 10;
        
    }
    Console.WriteLine("Третья цифра: " + numberFirth);
}