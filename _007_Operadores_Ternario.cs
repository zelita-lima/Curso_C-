using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    internal class _007_Operadores_Ternario
    {
        public static void DemonstracoesOperadoresTernario()
        {
            int a = 5;  // Valor para 'a'
            int b = 10; // Valor para 'b'

            int maior = (a > b) ? a : b;// if else de uma linha so  
            Console.WriteLine($"O maior valor entre {a} e {b} é {maior}");

            int numero = 16;
            string resultado = (numero % 2 == 0) ? "par" : "ímpar";
            Console.WriteLine($"O número {numero} é {resultado}");

            string nome = "";
            string mensagem = (!string.IsNullOrEmpty(nome)) ? "Nome válido" : "Nome inválido";

            Console.WriteLine(mensagem);
        }
    }
}
