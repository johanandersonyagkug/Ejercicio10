 using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma ;

            Console.WriteLine("Introduce un números");
            numero = Convert.ToInt32(Console.ReadLine());
            suma = numero;
            while (numero != 0)
            {
                Console.WriteLine("Introduce un números");
                numero = Convert.ToInt32(Console.ReadLine());
                suma = suma + numero;
            }

            Console.WriteLine("La suma es:{0} " ,suma);
            Console.WriteLine("preciona cualquier tecla para salir");
        }
    }
}   


    

