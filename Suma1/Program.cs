using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 8;
            double num2 = 4.5;
            double resultado;

            //variable string
            string saludo = "Hola";
            string nombre = "Hugo";
            //sumamos las dos variables
            //resultado = num1 + num2;

            //sumando una variable y un dato puesto explicitamente
            resultado= num1+22;
            //Console.WriteLine(resultado);

            Console.WriteLine(saludo + "   " + nombre + "   " + "Como estas?");
            Console.ReadKey();
        }
    }
}
