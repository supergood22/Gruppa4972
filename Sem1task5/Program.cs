int a = int.Parse(Console.ReadLine());
if (a < 0) a = -a;
for(int i = -a; i <= a; i++){
    Console.Write(i + ", ");
    Console.Write(" ");
}