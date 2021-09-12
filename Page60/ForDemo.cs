//Продемонстрировать применение оператора цикла for.

using System;

class ForDemo
{
    static void Main()
    {
        int count;
        for(count = 0; count < 5; count++)
            Console.WriteLine("Это подсчёт: " + count);
        
        Console.WriteLine("Готово!");
    }
}