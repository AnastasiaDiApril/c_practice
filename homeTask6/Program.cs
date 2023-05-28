Console.WriteLine("Введите число ");
string m = Console.ReadLine();
int N = Convert.ToInt32(m);
if (N >= 100){
    Console.WriteLine(m[2]);
}
else Console.WriteLine("третьей цифры нет");