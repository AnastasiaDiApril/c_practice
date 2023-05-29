
Console.WriteLine("Введите размер массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
FillArr(arr);
PrintArr(arr);

void FillArr(int[] arr) {
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1,99);
    }
}

void PrintArr(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write(arr[i] + " ");
    }
}
