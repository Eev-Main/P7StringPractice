using System;
using System.Collections.Generic;

namespace P7StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");

            String value1 = "hola";
            string value2 = value1.ToUpper();

            Console.WriteLine("\"" + value1 + "\" -> \"" + value2 + "\"");

            Console.WriteLine("-------------------");

            value1 = "John, Peter, Charlie";
            string[] value2arry = value1.Split(",");
            value2 = string.Join(",",value2arry);
            Console.WriteLine("\"" + value1 + "\" -> [\"" + value2 + "\"]");

            Console.WriteLine("-------------------");

            value1 = "Pizza";
            char[] charArray = value1.ToCharArray();
            Array.Reverse( charArray);
            value2 = new string( charArray);
            Console.WriteLine("\"" + value1 + "\" -> \"" + value2 + "\"");

            Console.WriteLine("-------------------");

            value1 = "Tacos > Hamburguesa";
            value2 = value1.Replace(">", "&gt;");
            Console.WriteLine("\"" + value1 + "\" -> \"" + value2 + "\"");

            Console.WriteLine("-------------------");

            value1 = "Pizza < Hamburguesa";
            value2 = value1.Replace("<", "&it;");
            Console.WriteLine("\"" + value1 + "\" -> \"" + value2 + "\"");

            Console.WriteLine("-------------------");

            value1 = "Azul, Verde, Morado";
            value2 = value1.Substring(13, 6);
            Console.WriteLine("\"" + value1 + "\" -> \"" + value2 + "\"");

            Console.WriteLine("-------------------");

            value1 = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            value2 = value1.ToUpper();
            value2arry = value2.Split(", ");
            Console.WriteLine("\"" + value1 + "\" -> " + value2arry[5] + ";" + value2arry[4] + ";" + value2arry[3] + ";" + value2arry[2] + ";" + value2arry[1]);

            Console.WriteLine("-------------------");
        }
    }
}
