Console.WriteLine("Введите три числа числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (x > max) max = x;

Console.Write("max = ");
Console.WriteLine(max);
