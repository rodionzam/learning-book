//Эта программа демонстрирует применение переменных.

using System;

class Example
{
    static void Main()
    {
        int x; //здесь объявляется переменная
        int y; //здесь объявляется ещё одна переменная

        x = 100; //здесь переменной x присваивается значение 100

        Console.WriteLine("x содержит " + x);

        y = x / 2;

        Console.Write("y содержит x / 2: ");
        Console.WriteLine(y);
    }
}