using CursoCSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso_C_
{

    public class Livro
    {
        public string NomeLivro;
        public int Anolivro;
    }
    public class Exercicio
    {
        public void Seila()
        {
            var LivrosList = new List<Livro>
            {
                 new Livro { NomeLivro = "O duque e eu ", Anolivro = 2000 },
                 new Livro { NomeLivro = "Ainda sou eu ", Anolivro = 2018 },
                 new Livro { NomeLivro = "Coraline", Anolivro = 2009 },
                 new Livro { NomeLivro = "Love", Anolivro = 2023 }
            };

            var ReceberLivros = pessoasList.Where(p => p.Anolivro >  2000) OrderBy(x => x.Anolivro).ToList();

            foreach(var livro in LivrosList)
            {
                Console.WriteLine($"{livro.NomeLivro}{livro.Anolivro}");
            }
        }
    }
}
    /*
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
    }

    public class Exercicio
    {
        public void Seila()
        {
            var pessoasList = new List<Pessoa>
            {
                new Pessoa { Nome = "zelita", Cidade = "brasilia", Idade = 18 },
                new Pessoa { Nome = "zelita", Cidade = "brasilia", Idade = 18 },
                new Pessoa { Nome = "zelita", Cidade = "brasilia", Idade = 18 },
                new Pessoa { Nome = "zelita", Cidade = "brasilia", Idade = 18 }
            };

            // Agrupar as pessoas por cidade
            var pessoaNovasCidade = pessoasList.GroupBy(p => p.Cidade);

            // Ordenar as pessoas por idade em cada grupo e criar uma lista
            var pessoasMaisNovas = pessoaNovasCidade
                .Select(g => g.OrderBy(p => p.Idade).ToList())
                .ToList();

            // Exibir o resultado
            foreach (var grupo in pessoasMaisNovas)
            {
                foreach (var pessoa in grupo)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}, Cidade: {pessoa.Cidade}, Idade: {pessoa.Idade}");
                }
                Console.WriteLine("-----");
            }
        }
    }
}

 public void Seila()
{
    var pessoasList = new List<PessoaNova>
    {
        new PessoaNova{Nome="Rodrigo", Cidade = "Brasilia" , Idade = 43 },
        new PessoaNova{Nome="Lia", Cidade = "São Paulo" , Idade = 19 },
        new PessoaNova{Nome="Zeze", Cidade = "Brasilia" , Idade = 18 },
        new PessoaNova{Nome="Arthur", Cidade = "Brasilia" , Idade = 29 },
        new PessoaNova{Nome="Davi", Cidade = "São Paulo" , Idade = 21 },
        new PessoaNova{Nome="Leo", Cidade = "Belem" , Idade = 19 },
        new PessoaNova{Nome="Suuh", Cidade = "Belem" , Idade = 22 }
    };

    var pessoaMaisJovemPorCidade = pessoasList
    .GroupBy(p => p.Cidade)
    .Select(grupo => grupo.OrderBy(p => p.Idade).First());

    Console.WriteLine("Pessoa mais jovem por cidade:");
    foreach (var pessoa in pessoaMaisJovemPorCidade)
    {
        Console.WriteLine($"{pessoa.Nome} de {pessoa.Cidade} com {pessoa.Idade} anos");
    }

}
*/