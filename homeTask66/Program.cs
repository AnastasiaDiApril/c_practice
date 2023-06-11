Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());

int start = Math.Max(1, Math.Min(N, M));
int end = Math.Max(N, M);

int sum = NaturalNumberSum(start, end);
Console.WriteLine($"N = {N}; M = {M} -> {sum}");


int NaturalNumberSum(int start, int end) {
    if (end > start) {
         return end + NaturalNumberSum(start, end - 1);
    } else {
        return end;
    }
}