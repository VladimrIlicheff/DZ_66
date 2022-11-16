/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);

int GetSum(int m, int n)
{   
    int sum;
     
    if (m >= n)
       return m;
    else
    {
        return sum = n + GetSum(m, n - 1);
    }
    
}


Console.WriteLine(GetSum(m, n));
