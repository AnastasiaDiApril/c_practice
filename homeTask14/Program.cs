const int ARRAY_LENGHT = 4;

int[] arr = new int[ARRAY_LENGHT];

FillInRndNum(arr);

int evenCount = CountEvenNumbers(arr);

PrintArr(arr);
Console.WriteLine($"Количество четных чисел = {evenCount}");

void FillInRndNum(int[] arr) {
    var generator = new Random();
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = generator.Next(100, 999);
    }
};

void PrintArr(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("");
};

int CountEvenNumbers(int[] arr) {
    int even = 0;
    for(int i = 0; i < arr.Length; i++) {
       if (arr[i] % 2 == 0) {
            even++;
       }
    }
    return even;
}