Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= a; i++){
    int sqr = i * i;
    Console.Write(sqr + ", ");
}
