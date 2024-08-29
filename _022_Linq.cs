using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso_C_
{
    public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

public class ExemploUsoLINQ
{
    public void DemonstrarUsoLINQ()
    {
        // Criando uma lista de produtos
        var produtos = new List<Produto>
            {
                new Produto { Nome = "Minuano", Preco = 30 },
                new Produto { Nome = "Ype", Preco = 25 },
                new Produto { Nome = "Omo", Preco = 35 },
                new Produto { Nome = "Downy", Preco = 40 }
            };

        // Exemplo 1: Consulta LINQ com Sintaxe de Consultas
        var produtosAcimaDe30 = from produto in produtos
                                where produto.Preco > 30
                                select produto;

        Console.WriteLine("Produtos com preço acima de 30 (Sintaxe de Consultas):");
        foreach (var produto in produtosAcimaDe30)
        {
            Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
        }

        // Exemplo 2: Consulta LINQ com Sintaxe de Método
        var produtosAcimaDe30Metodo = produtos.Where(p => p.Preco > 30);

        Console.WriteLine("\nProdutos com preço acima de 30 (Sintaxe de Método):");
        foreach (var produto in produtosAcimaDe30Metodo)
        {
            Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
        }

        // Exemplo 3: Projeção de Dados
        var nomesDosProdutos = produtos.Select(p => p.Nome);

        Console.WriteLine("\nNomes dos Produtos:");
        foreach (var nome in nomesDosProdutos)
        {
            Console.WriteLine(nome);
        }

        // Exemplo 4: Ordenação
        var produtosOrdenadosPorPreco = produtos.OrderBy(p => p.Preco);

        Console.WriteLine("\nProdutos Ordenados por Preço:");
        foreach (var produto in produtosOrdenadosPorPreco)
        {
            Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
        }

        // Exemplo 5: Agregação
        var precoMedio = produtos.Average(p => p.Preco);
        var precoMaximo = produtos.Max(p => p.Preco);
        var precoMinimo = produtos.Min(p => p.Preco);
        var totalProdutos = produtos.Count();

        Console.WriteLine("\nDados Agregados:");
        Console.WriteLine($"Preço Médio: R${precoMedio}");
        Console.WriteLine($"Preço Máximo: R${precoMaximo}");
        Console.WriteLine($"Preço Mínimo: R${precoMinimo}");
        Console.WriteLine($"Total de Produtos: {totalProdutos}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var exemplo = new ExemploUsoLINQ();
        exemplo.DemonstrarUsoLINQ();
    }
}
}

            Encontrar todos os nomes das pessoas que têm o nome começando com a letra 'A' e que têm mais de 25 anos.
        
             var result1 = people
            .Where(p => p.Name.StartsWith("A") && p.Age > 25)
            .Select(p => p.Name);

             foreach (var name in result1)
            {
                Console.WriteLine(name);
            }

            Encontrar os produtos cujo preço é superior à média de todos os produtos.

            var averagePrice = products.Average(p => p.Price);

            var result2 = products
                .Where(p => p.Price > averagePrice)
                .Select(p => p.Name);

            foreach (var productName in result2)
            {
                Console.WriteLine(productName);
            }


            Listar o nome das pessoas em ordem alfabética reversa.

            var result3 = people
            .OrderByDescending(p => p.Name)
            .Select(p => p.Name);

            foreach (var name in result3)
            {
                Console.WriteLine(name);
            }


            Encontrar a pessoa mais jovem de cada cidade.

            var result4 = people
            .GroupBy(p => p.City)
            .Select(g => g.OrderBy(p => p.Age).First());

            foreach (var person in result4)
            {
                Console.WriteLine($"{person.Name} from {person.City}, Age: {person.Age}");
            }

            Encontrar os livros publicados após o ano de 2000 e ordená-los por ano de publicação em ordem crescente.

            var result5 = books
            .Where(b => b.PublicationYear > 2000)
            .OrderBy(b => b.PublicationYear)
            .Select(b => b.Title);

             foreach (var bookTitle in result5)
             {
                 Console.WriteLine(bookTitle);
             }

            Listar todas as pessoas de uma cidade específica(suponha que a cidade seja "New York").

             var result6 = people
            .Where(p => p.City == "New York");

             foreach (var person in result6)
             {
                 Console.WriteLine(person.Name);
             }


            Encontrar a pessoa mais velha de cada cidade.

             var result7 = people
            .GroupBy(p => p.City)
            .Select(g => g.OrderByDescending(p => p.Age).First());

            foreach (var person in result7)
            {
                Console.WriteLine($"{person.Name} from {person.City}, Age: {person.Age}");
            }

            Calcular o salário médio das pessoas.

            var averageSalary = peopleWithSalaries.Average(p => p.Salary);

            Console.WriteLine($"Average Salary: {averageSalary}");

            Listar os nomes das pessoas que têm idade entre 20 e 30 anos e ordenar os resultados por nome.

            var result9 = people
            .Where(p => p.Age >= 20 && p.Age <= 30)
            .OrderBy(p => p.Name)
            .Select(p => p.Name);

             foreach (var name in result9)
             {
                 Console.WriteLine(name);
            }

            Contar quantas pessoas têm mais de 30 anos e imprimir o resultado.

            var count = people
           .Count(p => p.Age > 30);

            Console.WriteLine($"Number of people older than 30: {count}");
        }

    }

    // Classe de exemplo para representar uma pessoa
    public class Pessoa2
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
