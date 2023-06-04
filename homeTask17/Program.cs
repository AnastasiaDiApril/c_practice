const int M = 3;
const int N = 4;

double[,] arr = new double[M, N];

FillInRndNum(arr, -10, 10);
PrintArr(arr);


void FillInRndNum(double[,] arr, double lowerBound, double upperBound) {
    var generator = new Random();
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            double rnd = generator.NextDouble();
            arr[i, j] = Math.Round(rnd * (upperBound - lowerBound) + lowerBound, 1);
        }
    }
}

void PrintArr(double[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} ");
        }
         Console.WriteLine("");
    }
}



