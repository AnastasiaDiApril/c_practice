const int ARRAY_LENGHT = 10;

int[] arr = new int[ARRAY_LENGHT];

FillInRndNum(arr);
int sum = SumOddIndNumbers(arr);
PrintArr(arr);
Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");

void FillInRndNum(int[] arr) {
    var generator = new Random();
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = generator.Next(-10, 10);
    }
};

void PrintArr(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("");
};

int SumOddIndNumbers(int[] arr) {
    int sum = 0;
    for(int i = 0; i < arr.Length; i++) {
       if (i % 2 != 0) {
            sum += arr[i];
       }
    }
    return sum;
}
