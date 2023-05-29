Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int b = MultiNumb(N);
Console.WriteLine(b);

int MultiNumb(int numb){
    int count = 1;
    for(int i = 1; i <= numb; i++){
    count = count * i;
    }
    return count;
}