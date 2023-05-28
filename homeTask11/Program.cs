Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int b = Convert.ToInt32(Console.ReadLine());

 int degreenumb = 1;
for(int i = 1; i <= b; i++){
    degreenumb = degreenumb * a;  
}
Console.WriteLine(degreenumb);