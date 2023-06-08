const int M = 4;
const int N = 4;

int[,] arr = new int[M, N];

FillInNum(arr);
PrintArr(arr);


void FillInNum(int[,] arr) {
    int num = 1;
    int top = 0;
    int left = 0;
    int bottom = arr.GetLength(0) - 1;
    int right = arr.GetLength(1) - 1;
    while (true)
        {
            if (left > right) {
                break;
            }
            for (int i = left; i <= right; i++) {
                arr[top,i] = num++;
            }
            top++;
            if (top > bottom) {
                break;
            }
            for (int i = top; i <= bottom; i++) {
                arr[i,right] = num++;
            }
            right--;
 
            if (left > right) {
                break;
            }
            for (int i = right; i >= left; i--) {
                arr[bottom,i] = num++;
            }
            bottom--;
 
            if (top > bottom) {
                break;
            }
            for (int i = bottom; i >= top; i--) {
                arr[i,left] = num++;
            }
            left++;
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
