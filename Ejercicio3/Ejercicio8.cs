using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            string producto;
            int cant, bolita;
            double precio, total, des;
            Console.WriteLine("Bienvenidos a la tienda de Chepe segunda sucursal");
            Console.WriteLine("Ingrese el nombre del producto que lleva: ");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            total = cant * precio;
            Console.Clear();
            
            Console.WriteLine("Presione cualquier tecla para saber el color de la bolita:");
            Console.WriteLine("Segun el color de la bolita obtendra un descuento");            
            Console.WriteLine("Blanca ------ 0%");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Verde ------- 15%");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Amarilla ---- 18%");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Azul -------- 20%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Roja -------- 25%");
            Console.ReadKey();
            Console.Clear();
            Random bola = new Random();
            bolita = bola.Next(1, 6);
            if (bolita == 1)
            {
                Console.WriteLine("El color de la bolita es blanco, su descuento es 0%.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.0;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            else if (bolita == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El color de la bolita es blanco, su descuento es 15%.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.15;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            else if (bolita == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("El color de la bolita es blanco, su descuento es 18%.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.18;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            else if (bolita == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("El color de la bolita es blanco, su descuento es 20%.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.20;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            else if (bolita == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El color de la bolita es blanco, su descuento es 25%.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.25;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            Console.ReadKey();
        }
    }
}
