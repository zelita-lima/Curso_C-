using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _011_Array
    {
        public static void DemonstracaodeArray()
        { // Inicialização de arrays
            int[] numeros = new int[5];
            string[] diasSemana = { "Domingo", "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado" };

            // Atribuição de valores ao array 'numeros'
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            // Nota: Acesso aos índices 5 e 6 está fora do limite do array 'numeros', que possui apenas 5 elementos.

            Console.WriteLine("Acessando elementos do array:");
            Console.WriteLine($"Primeiro elemento de numeros: {numeros[0]}");
            Console.WriteLine($"Terceiro dia da semana: {diasSemana[2]}");

            Console.WriteLine("\nInteração usando 'for':");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Elemento [{i}] do array numeros: {numeros[i]}");
            }

            Console.WriteLine("\nInteração usando 'foreach':");
            foreach (string dia in diasSemana)
            {
                Console.WriteLine($"Dia da semana: {dia}");
            }

            // Inicialização de array multidimensional
            int[,] matriz = new int[3, 2]
            {
        { 1, 2 },
        { 3, 4 },
        { 5, 6 }
            };

            Console.WriteLine("\nAcessando elementos de um array multidimensional:");
            Console.WriteLine($"Elemento (0,0) da matriz: {matriz[0, 0]}");
            Console.WriteLine($"Elemento (1,1) da matriz: {matriz[1, 1]}");

            // Inicialização de array jagged
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("\nAcessando elementos de um array jagged:");
            Console.WriteLine($"Elemento (1,1) do jaggedArray: {jaggedArray[1][1]}");
            Console.WriteLine($"Elemento (2,3) do jaggedArray: {jaggedArray[2][3]}");
        }
    }
}
