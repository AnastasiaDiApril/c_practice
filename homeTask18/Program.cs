const int M = 3;
const int N = 4;

int[,] arr = new int[M, N];

FillInRndNum(arr, 0, 20);
PrintArr(arr);

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

FindPosition(arr, a);


void FillInRndNum(int[,] arr, int lowerBound, int upperBound) {
    var generator = new Random();
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = generator.Next(lowerBound, upperBound);
        }
    }
}

void PrintArr(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} ");
        }
         Console.WriteLine("");
    }
}

void FindPosition(int[,] arr, int a) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            if (arr[i, j] == a) {
                Console.WriteLine($"число найдено, позиция: {i}, {j}");
                return;
            }
        }
    }
    Console.WriteLine("такого числа в массиве нет");
}
