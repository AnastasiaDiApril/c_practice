const int M = 3;
const int N = 4;

int[,] arr = new int[M, N];

FillInRndNum(arr, 0, 20);
PrintArr(arr);

SortArrByLine(arr);
Console.WriteLine("После сортировки");
PrintArr(arr);


void SortArrByLine(int[,] arr) {
     for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            int tmp;
            for (int k = 0; k < arr.GetLength(1) - j - 1; k++) {
                if (arr[i, k] < arr[i, k+1]) {
                    tmp = arr[i, k];
                    arr[i, k] = arr[i, k+1];
                    arr[i, k+1] = tmp;
                }
            }
        }
    }
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
