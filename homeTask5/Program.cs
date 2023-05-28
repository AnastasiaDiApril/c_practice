Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 100 && N <= 999){
    int modulo = N % 100;
    int numb = modulo / 10;
    Console.WriteLine(numb);
} 
else Console.WriteLine("только трезначное число");
     