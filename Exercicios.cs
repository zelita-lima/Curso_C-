using System;
using System.Collections.Generic;
using System.Linq;
/*
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

            Console.WriteLine("Produtos com pre�o acima de 30 (Sintaxe de Consultas):");
            foreach (var produto in produtosAcimaDe30)
            {
                Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
            }

            // Exemplo 2: Consulta LINQ com Sintaxe de M�todo
            var produtosAcimaDe30Metodo = produtos.Where(p => p.Preco > 30);

            Console.WriteLine("\nProdutos com pre�o acima de 30 (Sintaxe de M�todo):");
            foreach (var produto in produtosAcimaDe30Metodo)
            {
                Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
            }

            // Exemplo 3: Proje��o de Dados
            var nomesDosProdutos = produtos.Select(p => p.Nome);

            Console.WriteLine("\nNomes dos Produtos:");
            foreach (var nome in nomesDosProdutos)
            {
                Console.WriteLine(nome);
            }

            // Exemplo 4: Ordena��o
            var produtosOrdenadosPorPreco = produtos.OrderBy(p => p.Preco);

            Console.WriteLine("\nProdutos Ordenados por Pre�o:");
            foreach (var produto in produtosOrdenadosPorPreco)
            {
                Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
            }

            // Exemplo 5: Agrega��o
            var precoMedio = produtos.Average(p => p.Preco);
            var precoMaximo = produtos.Max(p => p.Preco);
            var precoMinimo = produtos.Min(p => p.Preco);
            var totalProdutos = produtos.Count();

            Console.WriteLine("\nDados Agregados:");
            Console.WriteLine($"Pre�o M�dio: R${precoMedio}");
            Console.WriteLine($"Pre�o M�ximo: R${precoMaximo}");
            Console.WriteLine($"Pre�o M�nimo: R${precoMinimo}");
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

        Console.WriteLine("Produtos com pre�o acima de 30 (Sintaxe de Consultas):");
        foreach (var produto in produtosAcimaDe30)
        {
            Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
        }

        // Exemplo 2: Consulta LINQ com Sintaxe de M�todo
        var produtosAcimaDe30Metodo = produtos.Where(p => p.Preco > 30);

        Console.WriteLine("\nProdutos com pre�o acima de 30 (Sintaxe de M�todo):");
        foreach (var produto in produtosAcimaDe30Metodo)
        {
            Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
        }

        // Exemplo 3: Proje��o de Dados
        var nomesDosProdutos = produtos.Select(p => p.Nome);

        Console.WriteLine("\nNomes dos Produtos:");
        foreach (var nome in nomesDosProdutos)
        {
            Console.WriteLine(nome);
        }

        // Exemplo 4: Ordena��o
        var produtosOrdenadosPorPreco = produtos.OrderBy(p => p.Preco);

        Console.WriteLine("\nProdutos Ordenados por Pre�o:");
        foreach (var produto in produtosOrdenadosPorPreco)
        {
            Console.WriteLine($"{produto.Nome}, R${produto.Preco}");
        }

        // Exemplo 5: Agrega��o
        var precoMedio = produtos.Average(p => p.Preco);
        var precoMaximo = produtos.Max(p => p.Preco);
        var precoMinimo = produtos.Min(p => p.Preco);
        var totalProdutos = produtos.Count();

        Console.WriteLine("\nDados Agregados:");
        Console.WriteLine($"Pre�o M�dio: R${precoMedio}");
        Console.WriteLine($"Pre�o M�ximo: R${precoMaximo}");
        Console.WriteLine($"Pre�o M�nimo: R${precoMinimo}");
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

            Encontrar todos os nomes das pessoas que t�m o nome come�ando com a letra 'A' e que t�m mais de 25 anos.
        
             var result1 = people
            .Where(p => p.Name.StartsWith("A") && p.Age > 25)
            .Select(p => p.Name);

             foreach (var name in result1)
            {
                Console.WriteLine(name);
            }

            Encontrar os produtos cujo pre�o � superior � m�dia de todos os produtos.

            var averagePrice = products.Average(p => p.Price);

            var result2 = products
                .Where(p => p.Price > averagePrice)
                .Select(p => p.Name);

            foreach (var productName in result2)
            {
                Console.WriteLine(productName);
            }


            Listar o nome das pessoas em ordem alfab�tica reversa.

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

            Encontrar os livros publicados ap�s o ano de 2000 e orden�-los por ano de publica��o em ordem crescente.

            var result5 = books
            .Where(b => b.PublicationYear > 2000)
            .OrderBy(b => b.PublicationYear)
            .Select(b => b.Title);

             foreach (var bookTitle in result5)
             {
                 Console.WriteLine(bookTitle);
             }

            Listar todas as pessoas de uma cidade espec�fica(suponha que a cidade seja "New York").

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

            Calcular o sal�rio m�dio das pessoas.

            var averageSalary = peopleWithSalaries.Average(p => p.Salary);

            Console.WriteLine($"Average Salary: {averageSalary}");

            Listar os nomes das pessoas que t�m idade entre 20 e 30 anos e ordenar os resultados por nome.

            var result9 = people
            .Where(p => p.Age >= 20 && p.Age <= 30)
            .OrderBy(p => p.Name)
            .Select(p => p.Name);

             foreach (var name in result9)
             {
                 Console.WriteLine(name);
            }

            Contar quantas pessoas t�m mais de 30 anos e imprimir o resultado.

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

