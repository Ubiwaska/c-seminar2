// Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int n;
        while(true)
        {
            Console.WriteLine("Введите трехзначное чиcло");  
            if (int.TryParse(Console.ReadLine(), out n))
            {
            
                int a1 = (n - n % 100) / 100; // a1 содержит все цифры числа не включая две последних или равно нулю если число сожержит менее трех цифр
                
                if (a1 > 0 && a1 < 10) 
                { 
                    int a2 = (n / 10) % 10;
                    Console.WriteLine(n + "->" + a2);  
                    break; 
                } 
                else 
                { 
                    Console.WriteLine("Ошибка ввода: вы ввели не трехзначное число.");    
                }
            }
            else
            {
            Console.WriteLine("Ошибка ввода!: Введите число типа int"); 
            }
        }