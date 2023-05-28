Console.WriteLine("Введите число ");
string m = Console.ReadLine();
int N = Convert.ToInt32(m);
if (N > 9999 && N < 100000){
    Console.Write("Палиндром: ");
    if (m[0] == m[4] && m[1] == m[3]){
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
else Console.WriteLine("ошибка");
