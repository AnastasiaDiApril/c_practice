        Console.WriteLine("Введите число ");
        int N = Convert.ToInt32(Console.ReadLine());
        int numb = 1;
     
        while(numb <= N ){
            int modulo = numb % 2;
            if(modulo == 0){
                Console.WriteLine(numb);
            }
            numb++;
            
        }
    
