using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _010_Estrutura_Repeticao
    {
        public static void DemonstracaoDeEstruturaRepeticao()
        {
            Console.WriteLine("Estrutura for:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Interação {i}");
            }

            Console.WriteLine("\nEstrutura while:");
            int contadorWhile = 0;
            while (contadorWhile < 5)
            {
                Console.WriteLine($"Interação {contadorWhile}");
                contadorWhile++;
            }

            Console.WriteLine("\nEstrutura do while:");
            int contadorDoWhile = 0;
            do
            {
                Console.WriteLine($"Interação {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile < 5);

            Console.WriteLine("\nEstrutura foreach:");
            string[] frutas = { "maçã", "banana", "laranja", "uva" };
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
