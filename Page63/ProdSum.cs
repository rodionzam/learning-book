//Вычислить сумму и произведение чисел от 1 до 10.

using System;

class ProdSum
{
    static void Main()
    {
        int prod, sum, i;

        sum = 0;
        prod = 1;

        for (i = 1; i <= 10; i++)
        {
            sum += i;
            prod *= i;
        }

        Console.WriteLine("Сумма равна " + sum);
        Console.WriteLine("Произведение равно " + prod);
    }
}