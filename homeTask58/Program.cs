const int M = 2;
const int N = 2;

int[,] arr1 = new int[M, N];
int[,] arr2 = new int[M, N];

FillInRndNum(arr1, 0, 10);
FillInRndNum(arr2, 0, 10);

Console.WriteLine("arr1:");
PrintArr(arr1);
Console.WriteLine("arr2:");
PrintArr(arr2);

int[,] result = MultiplyArrays(arr1, arr2);
Console.WriteLine("result:");
PrintArr(result);

int [,] MultiplyArrays(int[,] arr1, int[,] arr2) {
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); ++i) {
        for (int j = 0; j < arr2.GetLength(1); ++j) {
          for (int k = 0; k < arr1.GetLength(1); ++k) {
            result[i,j] += arr1[i,k] * arr2[k,j];
          }
        }
    }
    return result;  
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

