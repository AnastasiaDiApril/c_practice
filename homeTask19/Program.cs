const int M = 3;
const int N = 4;

int[,] arr = new int[M, N];

FillInRndNum(arr, 0, 20);
PrintArrInt(arr);

double[] avgByLine = CountAverageByLine(arr);
PrintArrDouble(avgByLine);


void FillInRndNum(int[,] arr, int lowerBound, int upperBound) {
    var generator = new Random();
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = generator.Next(lowerBound, upperBound);
        }
    }
}

void PrintArrInt(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} ");
        }
         Console.WriteLine("");
    }
}

void PrintArrDouble(double[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
}

double[] CountAverageByLine(int[,] arr) {
    double[] average = new double[arr.GetLength(1)];

    for(int i = 0; i < arr.GetLength(1); i++) {
        average[i] = 0;
        for (int j = 0; j < arr.GetLength(0); j++) {
             average[i] += arr[j,i];
        }
        average[i] = average[i] / arr.GetLength(0);
    }
    return average;
}
