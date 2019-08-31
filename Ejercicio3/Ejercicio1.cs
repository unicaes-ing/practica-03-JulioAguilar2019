using System;
//Julio Israel Aguilar Melgar
namespace Ejercicio3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int hora, minutos, segundos;

            Console.WriteLine("Ingrese la cantidad de horas:");
            hora = Convert.ToInt32(Console.ReadLine());
            minutos = hora * 60;
            Console.WriteLine("Conversión en minutos:" + minutos);
            segundos = hora * 3600;
            Console.WriteLine("Conversión en segundos: " + segundos);
            Console.ReadKey();

        }
    }
}
