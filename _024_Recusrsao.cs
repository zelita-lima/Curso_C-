using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    internal class _024_Recusrsao
    {
        public class Recursao
        {
            // Método para calcular o fatorial de um número usando recursão
            public int CalcularFatorial(int numero)
            {
                if (numero <= 1)
                    return 1; // Caso base: fatorial de 0 ou 1 é 1
                else
                    return numero * CalcularFatorial(numero - 1); // Chamada recursiva
            }

            // Método para calcular a sequência de Fibonacci até um determinado termo usando recursão
            public int CalcularFibonacci(int termo)
            {
                if (termo == 0)
                    return 0; // Caso base: Fibonacci de 0 é 0
                else if (termo == 1)
                    return 1; // Caso base: Fibonacci de 1 é 1
                else
                    return CalcularFibonacci(termo - 1) + CalcularFibonacci(termo - 2); // Chamada recursiva
            }

            // Método para demonstrar o conceito de recursão
            public void DemonstrarRecursao()
            {
                Console.WriteLine("Fatorial de 5: " + CalcularFatorial(5));
                Console.WriteLine("Fibonacci do 6º termo: " + CalcularFibonacci(6));
            }
        }

    }
}
