int N = Convert.ToInt32(Console.ReadLine());
int negatN = N * -1;

while (negatN <= N)
{
    Console.Write(negatN);
    Console.Write(" ");
    negatN++;
}
