int len = RequestNumberCount();
int[] numbers = FillArr(len);
int positive = CountPositiveNumbers(numbers);
Console.WriteLine("Количество числе > 0: " + positive);


int RequestNumberCount() {
    Console.WriteLine("Введите количество числе");
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArr(int len) {
    int[] numbers = new int[len];
    for(int i = 0; i < len; i++) {
         Console.WriteLine("?");
         numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

int CountPositiveNumbers(int[] numbers) {
    int count = 0;
    for(int i = 0; i < numbers.Length; i++) {
        if(numbers[i]>0) {
           count+=1; 
        }
    }
    return count;
}