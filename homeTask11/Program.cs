Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int b = Convert.ToInt32(Console.ReadLine());
int c = DegreeNumb(a, b);
Console.WriteLine(c);

int DegreeNumb(int numb, int degree){
    int acc = 1;
    for(int i = 1; i <= degree; i++){
        acc = acc * numb;  
    }
    return acc;
}
