string s = Console.ReadLine();
int a = Convert.ToInt32(s);
if(a >= 100 && a <= 999){
    int c = a % 10;
    Console.WriteLine(c);
}
else{
    Console.WriteLine("число не трехзначное");
}    