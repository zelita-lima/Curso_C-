using System;
using System.Collections.Generic;

namespace Curso_C_
{
    // Classe Livro
    public class Livro2
    {
        // Atributos privados
        private string titulo;
        private string autor;
        private int anoPublicacao;
        private int numeroPaginas;

        // Propriedades públicas com encapsulamento
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int AnoPublicacao
        {
            get { return anoPublicacao; }
            set { anoPublicacao = value; }
        }

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        // Construtor
        public Livro2(string titulo, string autor, int anoPublicacao, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.numeroPaginas = numeroPaginas;
        }

        // Método para exibir detalhes do livro
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Páginas: {NumeroPaginas}");
        }
    }

    // Classe Biblioteca
    public class Biblioteca
    {
        // Lista privada de livros
        private List<Livro2> acervo = new List<Livro2>();

        // Método para adicionar um livro
        public void AdicionarLivro(Livro2 livro)
        {
            if (livro != null)
            {
                acervo.Add(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
            }
            else
            {
                Console.WriteLine("O livro não pode ser nulo.");
            }
        }

        // Método para remover um livro
        public void RemoverLivro(Livro2 livro)
        {
            if (livro != null && acervo.Contains(livro))
            {
                acervo.Remove(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' removido da biblioteca.");
            }
            else
            {
                Console.WriteLine("O livro não está na biblioteca ou é nulo.");
            }
        }

        // Método para buscar um livro por título
        public Livro2 BuscarLivroPorTitulo(string titulo)
        {
            return acervo.Find(livro => livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        // Método para listar todos os livros
        public void ListarLivros()
        {
            if (acervo.Count > 0)
            {
                foreach (var livro in acervo)
                {
                    livro.ExibirDetalhes();
                }
            }
            else
            {
                Console.WriteLine("Não há livros na biblioteca.");
            }
        }
    }

    // Classe Usuario
    public class Usuario
    {
        // Atributos privados
        private string nome;
        private string cpf;
        private List<Livro2> livrosEmprestados = new List<Livro2>();

        // Construtor
        public Usuario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        // Método para emprestar um livro
        public void EmprestarLivro(Livro2 livro, Biblioteca biblioteca)
        {
            if (livro != null && biblioteca != null)
            {
                Livro2 livroEmprestado = biblioteca.BuscarLivroPorTitulo(livro.Titulo);
                if (livroEmprestado != null)
                {
                    livrosEmprestados.Add(livroEmprestado);
                    biblioteca.RemoverLivro(livroEmprestado);
                    Console.WriteLine($"{nome} emprestou o livro '{livro.Titulo}'.");
                }
                else
                {
                    Console.WriteLine("Livro não encontrado na biblioteca.");
                }
            }
            else
            {
                Console.WriteLine("O livro ou a biblioteca são nulos.");
            }
        }

        // Método para devolver um livro
        public void DevolverLivro(Livro2 livro, Biblioteca biblioteca)
        {
            if (livro != null && biblioteca != null)
            {
                if (livrosEmprestados.Contains(livro))
                {
                    livrosEmprestados.Remove(livro);
                    biblioteca.AdicionarLivro(livro);
                    Console.WriteLine($"{nome} devolveu o livro '{livro.Titulo}'.");
                }
                else
                {
                    Console.WriteLine("O livro não está emprestado por este usuário.");
                }
            }
            else
            {
                Console.WriteLine("O livro ou a biblioteca são nulos.");
            }
        }

        // Método para exibir livros emprestados
        public void ExibirLivrosEmprestados()
        {
            Console.WriteLine($"Livros emprestados por {nome}:");
            if (livrosEmprestados.Count > 0)
            {
                foreach (var livro in livrosEmprestados)
                {
                    livro.ExibirDetalhes();
                }
            }
            else
            {
                Console.WriteLine("Nenhum livro emprestado.");
            }
        }
    }

    // Classe Program
    class Program
    {
        static void Main(string[] args)
        {
            // Criar a biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Criar alguns livros
            Livro2 livro1 = new Livro2("1984", "George Orwell", 1949, 328);
            Livro2 livro2 = new Livro2("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 1216);

            // Adicionar livros à biblioteca
            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);

            // Criar um usuário
            Usuario usuario = new Usuario("Maria", "123.456.789-00");

            // Emprestar um livro
            usuario.EmprestarLivro(livro1, biblioteca);

            // Listar livros na biblioteca
            Console.WriteLine("\nLivros na biblioteca:");
            biblioteca.ListarLivros();

            // Exibir livros emprestados pelo usuário
            Console.WriteLine("\nLivros emprestados:");
            usuario.ExibirLivrosEmprestados();

            // Devolver um livro
            usuario.DevolverLivro(livro1, biblioteca);

            // Listar livros na biblioteca após devolução
            Console.WriteLine("\nLivros na biblioteca após devolução:");
            biblioteca.ListarLivros();

            // Exibir livros emprestados pelo usuário após devolução
            Console.WriteLine("\nLivros emprestados após devolução:");
            usuario.ExibirLivrosEmprestados();
        }
    }
}
