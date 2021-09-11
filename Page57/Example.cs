/*
 * Эта программа демонстрирует отличия
 * между типами данных int и duble
 */

using System;

class Example
{
    static void Main()
    {
        int ivar; //объявить целочисленную переменную
        double dvar; //объявить переменную с плавающей точкой

        ivar = 100; //присвоить переменной ivar значение 100

        dvar = 100.0; //присвоить переменной dvar значение 100.0

        Console.WriteLine("Исходное значение ivar:  " + ivar);
        Console.WriteLine("Исходное значение dvar:  " + dvar);

        Console.WriteLine(); //вывести пустую строку

        //Разделить значения обеих переменных на 3.
        ivar = ivar / 3;
        dvar = dvar / 3.0;

        Console.WriteLine("Значение ivar после деления:  " + ivar);
        Console.WriteLine("Значение dvar после деления:  " + dvar);
    }
}