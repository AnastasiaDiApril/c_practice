int Sum(int a){
    int sum = 0;
    for (int i = 1; i <= a; i++){
        sum += i;
    }
    return sum;
}
int result = Sum(7);
Console.WriteLine(result);