Console.Write("Введите подкоренное число ");
string a = Console.ReadLine();

Console.Write("Введите корень числа ");
string b = Console.ReadLine();

int c = Convert.ToInt32(a);
int d = Convert.ToInt32(b);

Console.Write("является ли корнем числа: "); 
if(c == d * d) 
{
   Console.WriteLine("ДА");  
}
else Console.WriteLine("Нет");

