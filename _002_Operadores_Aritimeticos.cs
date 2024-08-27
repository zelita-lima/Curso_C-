using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    internal class _002_Operadores_Aritimeticos
    { 
        public static void Soma()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Soma e;{n1 + n2}");

        }
        public static void Subtração()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Subtração e;{n1 - n2}");
        }
        public static void Divisão()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Divisão  e;{n1 / n2}");
        }
        public static void Multiplicação()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Multiplicação e;{n1 * n2}");
        }
        public static void Resto()
        {
            int n1 = 11, n2 = 2;
            Console.WriteLine($"O Resto e;{n1 % n2}");
        }
        public static void Incremento()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"O Incremento e;{n1++}");
        }
        public static void Decremento()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"O Decremento e;{n1--}");
        }
    }
}
