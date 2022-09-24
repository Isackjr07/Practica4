using System;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            double grados, Fahrenheit;

            Console.WriteLine("Escriba los grados centigrados: ");
            grados = Convert.ToDouble(Console.ReadLine());

            Fahrenheit = (grados * 1.8000) +32 ;
            
            Console.WriteLine("Grados centigrados a Fahrenheit son:{0} ",Fahrenheit);
        }
    }
}
