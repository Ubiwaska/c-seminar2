﻿// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int Promt(string message)
{

Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;

}

int GetThirdRank(int number)
{ 
    while (number > 999);
    {
        number = number % 10; 
    }
return number  % 10;

}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
       Console.WriteLine("Третьей цифры нет"); 
       return false;
    }
    return true;
}

int number = Promt("Введите число > ");
if (ValidateNumber(number))
{
     Console.WriteLine(number + "->" + GetThirdRank(number)); 
}

       