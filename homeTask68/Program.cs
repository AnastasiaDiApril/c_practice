Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());
int res = ack(N, M);

Console.WriteLine($"N = {N}, M = {M} -> A(N,M) = {res}");

int ack(int n, int m) {
    if (n == 0) {
        return m + 1;
    } else if (m == 0) {
        return ack(n - 1, 1);
    } else {
        return ack(n - 1, ack(n, m - 1));
    }
}