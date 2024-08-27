using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class ExemploUsoDynamic
    {
        public void DemonstrarUsoDynamic()
        {
            // Exemplo 1: Declaração e Inicialização com Dynamic
            dynamic valorDynamic = 10; // Inicialmente um int
            Console.WriteLine($"valorDynamic: {valorDynamic}, Tipo: {valorDynamic.GetType()}");

            // Alterando o valor para uma string
            valorDynamic = "Olá, dynamic!";
            Console.WriteLine($"valorDynamic: {valorDynamic}, Tipo: {valorDynamic.GetType()}");

            // Exemplo 2: Manipulação de Propriedades e Métodos com ExpandoObject
            dynamic pessoa = new ExpandoObject();
            pessoa.Nome = "Alice";
            pessoa.Idade = 30;
            pessoa.Saudar = (Action)(() => Console.WriteLine($"Olá, meu nome é {pessoa.Nome} e eu tenho {pessoa.Idade} anos."));

            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            pessoa.Saudar();

            // Exemplo 3: Chamadas de Métodos Dinâmicos
            dynamic operacoesMatematicas = new OperacoesMatematicas();
            Console.WriteLine($"Soma: {operacoesMatematicas.Adicionar(5, 3)}");
            Console.WriteLine($"Subtração: {operacoesMatematicas.Subtrair(10, 4)}");

            // Exemplo 4: Problemas com Dynamic
            try
            {
                valorDynamic.MetodoInexistente(); // Isso causará uma exceção em tempo de execução
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine($"RuntimeBinderException: {ex.Message}");
            }

            try
            {
                valorDynamic = 42; // valorDynamic é um int agora
                                   // Tentativa de chamar um método inexistente para um int
                valorDynamic.MetodoInexistente(); // Isso causará uma exceção em tempo de execução
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine($"RuntimeBinderException: {ex.Message}");
            }
        }
    }

    // Classe de exemplo para operações matemáticas
    public class OperacoesMatematicas
    {
        public int Adicionar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
