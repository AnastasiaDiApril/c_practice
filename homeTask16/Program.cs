const int ARRAY_LENGHT = 10;

double[] arr = new double[ARRAY_LENGHT];

FillInRndNum(arr, -10, 10);
PrintArr(arr);

double max = FindMax(arr);
double min = FindMin(arr);

Console.WriteLine($"min={min}, max={max}, delta={max - min}");

void FillInRndNum(double[] arr, double lowerBound, double upperBound) {
    var generator = new Random();
    for(int i = 0; i < arr.Length; i++) {
        double rnd = generator.NextDouble();
        arr[i] = rnd * (upperBound - lowerBound) + lowerBound;
    }
};

void PrintArr(double[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("");
};

double FindMax(double[] arr) {
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}

double FindMin(double[] arr) {
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++) {
        if (arr[i] < min) {
            min = arr[i];
        }
    }
    return min;
}



