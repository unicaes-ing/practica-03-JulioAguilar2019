using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int num;
            
            string[] letras = {"Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez"};
            Console.WriteLine("Ingrese un número del 1 al 10 y se lo devuelvo en letras");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(letras[num - 1]);
            Console.ReadKey();
            
        }
    }
}
