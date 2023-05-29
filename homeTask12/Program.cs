Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = SumNumb(a);
Console.WriteLine(b);

int SumNumb(int numb){
    int r = 0;
    int acc = 0;
    while(numb != 0){
        r = numb % 10;
        acc = acc + r;
        numb = numb / 10;
        
    }
    return acc;
}
