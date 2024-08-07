using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class OPeradores_Atribuicao
    {
        public static void AtribuicaoSimples()
        {
           int a = 10;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoSoma()
        {
            int a = 10;
            a += 5;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoSUbtracao()
        {
            int a = 10;
            a -= 3;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoMultiplicacao()
        {
            int a = 10;
            a *= 4;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoDivisao()
        {
            int a = 10;
            a /= 4;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoModulos()
        {
            int a = 10;
            a %= 3;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoAnd()
        {
            int a = 12;
            a &= 7;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoOr()
        {
            int a = 12;
            a |= 5;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoXor()
        {
            int a = 12;
            a ^= 6;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoLocamentoEsquerda()
        {
            int a = 10;
            a <<= 2;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }

        public static void AtribuicaoLocamentoDireita()
        {
            int a = 16;
            a >>= 2;
            Console.WriteLine($"Valor de a apos atribuição;{a}");
        }
    }
}
