using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _008_Conversao
    {
        public static void DemonstracaoDeConversoes()
        {
            int numInt = 160;
            long numLong = numInt;  // Conversão implícita de int para long
            Console.WriteLine($"Conversão implícita de int para long: {numLong}");

            double numDouble = 1234.56;
            int numCast = (int)numDouble;  // Conversão explícita de double para int (truncamento)
            Console.WriteLine($"Conversão de double para int usando cast: {numCast}");

            string numeroString = "456";
            int numConvert = Convert.ToInt32(numeroString);  // Conversão de string para int usando Convert
            Console.WriteLine($"Conversão de string para int usando Convert: {numConvert}");

            string numeroString2 = "789";
            int numParse = int.Parse(numeroString2);  // Conversão de string para int usando Parse
            Console.WriteLine($"Conversão de string para int usando Parse: {numParse}");

            string numeroInvalido = "abc";
            bool conversaoSucesso = int.TryParse(numeroInvalido, out int numTryparse);  // Tentativa de conversão com TryParse
            Console.WriteLine($"Conversão com TryParse (sucesso): {conversaoSucesso}, valor: {numTryparse}");

            object obj = 1234;
            int numUnboxed = (int)obj;  // Unboxing de object para int
            Console.WriteLine($"Unboxing de object para int: {numUnboxed}");

            int numero = 42;
            string numeroString = numero.ToString();  // Conversão de int para string usando ToString
            Console.WriteLine($"Conversão de int para string: {numeroString}");
        }
    }
}
