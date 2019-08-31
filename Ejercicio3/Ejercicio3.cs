using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Programa para ordenar en forma ascendete los números");
            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                if (num2 > num3) Console.WriteLine("Los numeros ordenados son: " + num3 + ", " + num2 + ", " + num1);
                else if (num1 > 3) Console.WriteLine("Los numeros ordenados son: " + num2 + ", " + num3 + "," + num1);
                else { Console.WriteLine("Los numeros ordenados son:" + num2 + ", " + num1 + "," + num3); }
            else if (num1 > num3) Console.WriteLine("Los numeros ordenados son: " + num3 + ", " + num1 + ", " + num2);
            else if (num2 > num3) Console.WriteLine("Los numeros ordenados son: " + num1 + ", " + num3 + ", " + num2);
            else if (num2 > num3) Console.WriteLine("Los numeros ordenados son: " + num1 + ", " + num2 + ", " + num3);
            Console.ReadKey();             


        }
    }
}
