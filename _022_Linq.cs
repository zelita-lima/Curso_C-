using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class ExemploUsoLINQ
    {
        public void DemonstrarUsoLINQ()
        {
            // Criando uma lista de pessoas
            var pessoas = new List<Pessoa2>
    {
        new Pessoa2 { Nome = "Alice", Idade = 30 },
        new Pessoa2 { Nome = "Bob", Idade = 25 },
        new Pessoa2 { Nome = "Charlie", Idade = 35 },
        new Pessoa2 { Nome = "Diana", Idade = 40 }
    };

            // Exemplo 1: Consulta LINQ com Sintaxe de Consultas
            var pessoasComIdadeAcimaDe30 = from pessoa in pessoas
                                           where pessoa.Idade > 30
                                           select pessoa;

            Console.WriteLine("Pessoas com idade acima de 30 (Sintaxe de Consultas):");
            foreach (var pessoa in pessoasComIdadeAcimaDe30)
            {
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
            }

            // Exemplo 2: Consulta LINQ com Sintaxe de Método
            var pessoasComIdadeAcimaDe30Metodo = pessoas.Where(p => p.Idade > 30);

            Console.WriteLine("\nPessoas com idade acima de 30 (Sintaxe de Método):");
            foreach (var pessoa in pessoasComIdadeAcimaDe30Metodo)
            {
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
            }

            // Exemplo 3: Projeção de Dados
            var nomesDasPessoas = pessoas.Select(p => p.Nome);

            Console.WriteLine("\nNomes das Pessoas:");
            foreach (var nome in nomesDasPessoas)
            {
                Console.WriteLine(nome);
            }

            // Exemplo 4: Ordenação
            var pessoasOrdenadasPorIdade = pessoas.OrderBy(p => p.Idade);

            Console.WriteLine("\nPessoas Ordenadas por Idade:");
            foreach (var pessoa in pessoasOrdenadasPorIdade)
            {
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
            }

            // Exemplo 5: Agregação
            var idadeMedia = pessoas.Average(p => p.Idade);
            var idadeMaxima = pessoas.Max(p => p.Idade);
            var idadeMinima = pessoas.Min(p => p.Idade);
            var totalPessoas = pessoas.Count();

            Console.WriteLine("\nDados Agregados:");
            Console.WriteLine($"Idade Média: {idadeMedia}");
            Console.WriteLine($"Idade Máxima: {idadeMaxima}");
            Console.WriteLine($"Idade Mínima: {idadeMinima}");
            Console.WriteLine($"Total de Pessoas: {totalPessoas}");
        }
    }

    // Classe de exemplo para representar uma pessoa
    public class Pessoa2
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
