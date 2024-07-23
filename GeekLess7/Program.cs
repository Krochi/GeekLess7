//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
using System;

class Program
{
static void Main()
{
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

Numbers(M, N);
}

static void Numbers(int M, int N)
{
if (M <= N)
{
Console.Write(M);
Numbers(M + 1, N);
}
}
}

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System; 

class Program
{
static void Main()
{
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbers = AckermannFunction(M, N);
Console.WriteLine($"({M}, {N}) равно: {numbers}");
}

static int AckermannFunction(int M, int N)
{
if (M == 0)
return N + 1;

else if (N == 0)
return AckermannFunction(M - 1, 1);

else
return AckermannFunction(M - 1, AckermannFunction(M, N - 1)); 
}
}



//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
     
        int[] array = { 10, 200, 3, 445, 55 };
     
        out_Array(array, array.Length - 1);
    }

    static void out_Array(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);

        out_Array(array, index - 1);
    }
}
