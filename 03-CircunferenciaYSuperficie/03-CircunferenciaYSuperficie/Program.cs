using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_CircunferenciaYSuperficie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, circunferencia, superficie; ;



            Console.WriteLine("Ingresar el diametro del circulo y la superficie: ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            circunferencia = a * 3.14;
            superficie = (b * b * 3.14);
            Console.WriteLine("La circunferencia es de: " + circunferencia);
            Console.WriteLine("La superficie es de: " + superficie);
            Console.ReadKey();
        }
    }
}
