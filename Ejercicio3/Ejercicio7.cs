using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            int menu, menu2;
            double cant, valor;
            Console.WriteLine("Conversión de unidades");
            Console.WriteLine("[1] Onza");
            Console.WriteLine("[2] Libra");
            Console.WriteLine("[3] Gramo");
            Console.WriteLine("[4] Tonelada");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();           
            switch (menu)
            {
                case 1:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");                    
                    Console.WriteLine("[1] Libra");
                    Console.WriteLine("[2] Gramo");
                    Console.WriteLine("[3] Tonelada");
                    menu2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDouble(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        valor = cant * 0.0625;
                        Console.WriteLine(cant + " oz equivale a " + valor + " lb");
                    }
                    else if (menu2 == 2)
                    {
                        valor = cant * 28.3495;
                        Console.WriteLine(cant + " oz equivale a " + valor + " g");
                    }
                    else if (menu2 == 3)
                    {
                        valor = cant / 35273.962;
                       Console.WriteLine(cant + " oz equivale a " + valor + " t");
                    }                    
                    break;
                case 2:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Onza");
                    Console.WriteLine("[2] Gramo");
                    Console.WriteLine("[3] Tonelada");
                    menu2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDouble(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        valor = cant / 16;
                        Console.WriteLine(cant + " lb equivale a " + valor + " oz");
                    }
                    else if (menu2 == 2)
                    {
                        valor = cant * 453.592;
                        Console.WriteLine(cant + " lb equivale a " + valor + " g");
                    }
                    else if (menu2 == 3)
                    {
                        valor = cant * 0.000453592;
                        Console.WriteLine(cant + " lb equivale a " + valor + " t");
                    }
                    break;
                case 3:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Onza");
                    Console.WriteLine("[2] Libra");
                    Console.WriteLine("[3] Tonelada");
                    menu2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDouble(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        valor = cant * 0.035274;
                        Console.WriteLine(cant + " g equivale a " + valor + " oz");
                    }
                    else if (menu2 == 2)
                    {
                        valor = cant * 0.00220462;
                        Console.WriteLine(cant + " g equivale a " + valor + " lb");
                    }
                    else if (menu2 == 3)
                    {
                        valor = cant * 0.000001;
                        Console.WriteLine(cant + " g equivale a " + valor + " t");
                    }
                    break;
                case 4:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Onza");
                    Console.WriteLine("[2] Libra");
                    Console.WriteLine("[3] gramo");
                    menu2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDouble(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        valor = cant * 35274;
                        Console.WriteLine(cant + " t equivale a " + valor + " oz");
                    }
                    else if (menu2 == 2)
                    {
                        valor = cant * 2204.62;
                        Console.WriteLine(cant + " t equivale a " + valor + " lb");
                    }
                    else if (menu2 == 3)
                    {
                        valor = cant * 1000000;
                        Console.WriteLine(cant + " t equivale a " + valor + " g");
                    }
                    break;
                default:
                    Console.WriteLine("Por favor ingrese un valor válido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
