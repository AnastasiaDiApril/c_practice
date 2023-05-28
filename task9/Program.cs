int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

int a = x2 - x1;
int b = y2 - y1;
double distance = Math.Sqrt(a*a+b*b);
Console.WriteLine("distance= " + distance);