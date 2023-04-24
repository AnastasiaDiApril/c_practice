Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

int modulo = a % 2;
if(modulo == 0){
   Console.WriteLine("да"); 
}
else{
    Console.WriteLine("нет"); 
}