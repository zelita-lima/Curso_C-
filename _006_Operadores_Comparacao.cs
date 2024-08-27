using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _006_Operadores_Comparacao
    {
        public static void DemonstrandoOperadores()
        {
            int a = 10;
            int b = 20;

            //igaul a (==)
            bool igual = (a == b);
            Console.WriteLine($" a == b:{igual}");

            //Diferente a (!=)
            bool Diferente = (a != b);
            Console.WriteLine($" a != b:{Diferente}");

            //Maior a (>)
            bool Maior = (a > b);
            Console.WriteLine($" a > b:{Maior}");

            //Menor a (<)
            bool Menor = (a < b);
            Console.WriteLine($" a < b:{Menor}");

            //MaiorIgual a (>=)
            bool MaiorIgual = (a >= b);
            Console.WriteLine($" a >= b:{MaiorIgual}");

            //MenorIgual a (<=)
            bool MenorIgual = (a <= b);
            Console.WriteLine($" a <= b:{MenorIgual}");


        }
    }
}
