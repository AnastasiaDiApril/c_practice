const int M = 4;
const int N = 4;

int[,] arr = new int[M, N];

FillInRndNum(arr, 0, 20);
PrintArr(arr);

int[] sumByLineArr = SumByLine(arr);
int minSumIndex = FindMinSumIndex(sumByLineArr);

Console.WriteLine($"номер строки с наименьшей суммой элементов: {minSumIndex}");

int FindMinSumIndex(int[] arr) {
    int min = arr[0];
    int indexOfMin = 0;
    for(int i = 0; i < arr.GetLength(0); i++) {
        if (min > arr[i]) {
            min = arr[i];
            indexOfMin = i; 
        }
    }
    return indexOfMin;
}

int[]  SumByLine(int[,] arr) {
    int[] sum = new int[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0); i++) {
        sum[i] = 0;
        for (int j = 0; j < arr.GetLength(1); j++) {
            sum[i] += arr[i, j];
        }
    }
    return sum;
}

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

