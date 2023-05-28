int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    Console.WriteLine("не выходной");
    break;

    case 6:
    case 7:
    Console.WriteLine("выходной");
    break;

    default:
    Console.WriteLine("неверное значение");   
    break; 
}