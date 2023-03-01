// программа, которая принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear(); 
int n; 
        while(true) 
        { 
            Console.WriteLine("Введите чиcло от 1 до 7");   
            if (int.TryParse(Console.ReadLine(), out n)) 
            {                 
                if (n > 0 && n < 8)
                {  
                   if (n > 5) 
                   { 
                    Console.WriteLine(n + " ->" + " Да"); 
break;
                   } 
                   else 
                   { 
                    Console.WriteLine(n + " ->" + " Нет"); 
break;
                   } 
                     
                }  
                else  
                {  
                    Console.WriteLine("Ошибка ввода: Введите число от 1 до 7.");     
                } 
            } 
            else 
            { 
            Console.WriteLine("Ошибка ввода!: Введите число типа int");  
            } 
        }