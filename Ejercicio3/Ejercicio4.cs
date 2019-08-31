using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int zona, min, seg;
            double costo, duracion;
         
                 
            Console.WriteLine("En que zona se encuentra:");
            Console.WriteLine("1. Zona Occidental");
            Console.WriteLine("2. Zona Central");
            Console.WriteLine("3. Zona Oriental");
            Console.WriteLine("4. Salir");
            zona = Convert.ToInt32(Console.ReadLine());         
             
            switch (zona)
            {
                case 1:
                    Console.WriteLine("Cuantos minutos duró la llamada: ");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantos segundos duró la llamada: ");
                    seg = Convert.ToInt32(Console.ReadLine());
                    duracion = (min * 60) + seg;
                    costo = duracion * 0.0054;
                    Console.WriteLine(string.Format("El costo de su llamada es de: {0:C2}", costo));
                    break;

                case 2:
                    Console.WriteLine("Cuantos minutos duró la llamada: ");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantos segundos duró la llamada: ");
                    seg = Convert.ToInt32(Console.ReadLine());
                    duracion = (min * 60) + seg;
                    costo = duracion * 0.0042;
                    Console.WriteLine(string.Format("El costo de su llamada es de: {0:C2}", costo));
                    break;

                case 3:
                    Console.WriteLine("Cuantos minutos duró la llamada: ");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantos segundos duró la llamada: ");
                    seg = Convert.ToInt32(Console.ReadLine());
                    duracion = (min * 60) + seg;
                    costo = duracion * 0.006;
                    Console.WriteLine(string.Format("El costo de su llamada es de: {0:C2}", costo));
                    break;
                case 4:
                    break;

            
            }

            Console.ReadKey();
        }
    }
}
