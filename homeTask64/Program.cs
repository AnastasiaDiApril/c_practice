Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {N} ->[");
NaturalNumber(N);
Console.WriteLine(" ]");

void NaturalNumber(int n) {
    if (n > 0) {
         Console.Write($" {n}");
         NaturalNumber(n - 1);
    } else {
        return;
    }
}
