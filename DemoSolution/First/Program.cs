// See https://aka.ms/new-console-template for more information


using First;
Console.WriteLine("Welcome To calculator");
Console.WriteLine("Please Enter A First Number :");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please Enter A Second Number :");
int b = int.Parse(Console.ReadLine());


Calculator C = new Calculator();
C.Add(a,b);

Console.WriteLine();
