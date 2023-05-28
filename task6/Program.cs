int[] points = new int[2];

for (int i = 0; i < points.Length; i++){
    points[i] = Convert.ToInt32(Console.ReadLine());
}
if (points[0] > 0 && points[1] > 0){
    Console.WriteLine("1-я четверть");
}
else if (points[0] < 0 && points[1] > 0){
    Console.WriteLine("2-я четверть");
}
else if (points[0] < 0 && points[1] < 0){
    Console.WriteLine("3-я четверть");
}
else if (points[0] > 0 && points[1] < 0){
    Console.WriteLine("4-я четверть");
}
else{
    Console.WriteLine("x = 0, y = 0");
}
