using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            string producto;
            int cant;
            double precio, total, des;
            Console.WriteLine("Bienvenidos a la tienda de Chepe");
            Console.WriteLine("Ingrese el nombre del producto que lleva: ");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            total = cant * precio;
            if (total <= 100)
            {
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.0;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
           else if (total >= 100.01 && total <= 200)
            {
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.12;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des; 
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            else if (total >= 200.01 && total <= 500)
            {
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.15;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            else if (total >= 500.01)
            {
                Console.WriteLine(string.Format("Su subtotal es: {0:C2}", total));
                des = total * 0.20;
                Console.WriteLine(string.Format("Su descuento es: {0:C2}", des));
                total -= des;
                Console.WriteLine(string.Format("Su total es: {0:C2}", total));
            }
            Console.ReadKey();
        }
    }
}
