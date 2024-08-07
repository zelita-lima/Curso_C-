using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class Tipos_Primitivos
    {
        public static void ImprimirTipos()
        {
            // Tipo inteiro de 8 bits com sinal
            sbyte VariavelSByte = -128; // Valores variam de -128 a 127
            Console.WriteLine($"sbyte: {VariavelSByte}");

            // Tipo inteiro de 8 bits sem sinal
            byte VariavelByte = 255; // Valores variam de 0 a 255
            Console.WriteLine($"byte: {VariavelByte}");

            // Tipo inteiro de 16 bits com sinal
            short VariavelShort = -32768; // Valores variam de -32,768 a 32,767
            Console.WriteLine($"short: {VariavelShort}");

            // Tipo inteiro de 16 bits sem sinal
            ushort VariavelUshort = 65535; // Valores variam de 0 a 65,535
            Console.WriteLine($"ushort: {VariavelUshort}");

            // Tipo inteiro de 32 bits com sinal
            int VariavelInt = -2147483648; // Valores variam de -2,147,483,648 a 2,147,483,647
            Console.WriteLine($"int: {VariavelInt}");

            // Tipo inteiro de 32 bits sem sinal
            uint VariavelUint = 4294967295U; // Valores variam de 0 a 4,294,967,295
            Console.WriteLine($"uint: {VariavelUint}");

            // Tipo inteiro de 64 bits com sinal
            long VariavelLong = -9223372036854775808L; // Valores variam de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
            Console.WriteLine($"long: {VariavelLong}");

            // Tipo inteiro de 64 bits sem sinal
            ulong VariavelUlong = 18446744073709551615UL; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"ulong: {VariavelUlong}");

            // Tipo inteiro de 64 bits sem sinal
            float VariavelFloat = 3.14f; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"float: {VariavelFloat}");

            // Tipo inteiro de 64 bits sem sinal
            double VariavelDouble = 3.14159263589793; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"double: {VariavelDouble}");

            // Tipo inteiro de 64 bits sem sinal
            decimal VariavelDecimal = 1792281625142643373950335M; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"decimal: {VariavelDecimal}");

            // Tipo inteiro de 64 bits sem sinal
            char VariavelChar = 'A'; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"char: {VariavelChar}");

            // Tipo inteiro de 64 bits sem sinal
            bool VariavelBool = true; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"bool: {VariavelBool}");

            // Tipo inteiro de 64 bits sem sinal
            object VariavelObject = null; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"object: {VariavelObject}");

            // Tipo inteiro de 64 bits sem sinal
            string VariavelString = "Olá, Mundo!"; // Valores variam de 0 a 18,446,744,073,709,551,615
            Console.WriteLine($"string: {VariavelString}");
        }
    }
}
