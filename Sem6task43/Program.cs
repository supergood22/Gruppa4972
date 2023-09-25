// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; з
// начения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Ввод элементов массива
Double[] MakeArr()
{
    Console.WriteLine("Введите коэффициенты b1, k1, b2 и k2 поочередно.");
    Double[] arr = new Double[4];
    int count = 0;
    while ( count <= 3)
    {
        string elemStr = Console.ReadLine()??",";
        Double elemInt = Convert.ToDouble(elemStr);
        arr[count] = elemInt;
        count += 1;
    }
    return arr;
}

// Выводит элементы массива в консоль
void OutputArray(Double[] array)
{
Console.WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]}");
}


//Расчет точки пересечения
double[] PointRes(Double[] arr)
{
    double[] pointXY = new double[2];
    double x = (arr[2] - arr[0])/(arr[1] - arr[3]);
    double y = arr[1] * x + arr[0];
    pointXY[0] = x;
    pointXY[1] = y;
    return pointXY;
}


Double[] userArr = MakeArr();
OutputArray(userArr);
double[] userPoint = PointRes(userArr);
Console.WriteLine($"({userPoint[0]}, {userPoint[1]})");