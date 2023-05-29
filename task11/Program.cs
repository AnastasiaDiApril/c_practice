Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = CountNumb(a);
Console.WriteLine(b);

int CountNumb(int numb){
    int i = 0;
    while(numb != 0){
        numb = numb / 10;
        i++;
    }
    return i;
}