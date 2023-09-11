// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
int numberDay = int.Parse(Console.ReadLine()??"0");

var week = new Dictionary<int, string>()
{
    { 1, "Monday"},
    { 2, "Tuesday"},
    { 3, "Wednesday"},
    { 4, "Thursday"},
    { 5, "Friday"},
    { 6, "Saturday"},
    { 7, "Sunday"}
};

string day = week[numberDay]; 
Console.WriteLine(numberDay == 6 || numberDay == 7 ? "Этот день выходной - " + day : "Этот день не выходной - " + day);
