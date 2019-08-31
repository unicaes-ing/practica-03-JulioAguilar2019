using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Número aleatorio para determinar si es par o impar");
            Random aleatorio = new Random();

            num = aleatorio.Next(0, 101);
            Console.WriteLine(num);
            if (num % 2 == 0) Console.WriteLine("El número es par");
            else Console.WriteLine("El número es impar");
            Console.ReadKey();

        }
    }
}
