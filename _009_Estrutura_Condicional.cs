using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _009_Estrutura_Condicional
    {
        public static void DemonstracaoDeEstruturaConsicionais()
        {
            int numero = 25;

            if (numero < 10)
            {
                Console.WriteLine("O número é menor que 10");
            }
            else if (numero < 20)
            {
                Console.WriteLine("O número é menor que 20");
            }
            else
            {
                Console.WriteLine("O número é 20 ou maior");
            }

            string diaSemana = "Segunda-Feira";

            switch (diaSemana)
            {
                case "Segunda-Feira":
                    Console.WriteLine("Hoje é Segunda-Feira");
                    break;
                case "Terça-Feira":
                    Console.WriteLine("Hoje é Terça-Feira");
                    break;
                case "Quarta-Feira":
                    Console.WriteLine("Hoje é Quarta-Feira");
                    break;
                default:
                    Console.WriteLine("Não é um dia da semana reconhecido");
                    break;
            }
        }
    }
}
