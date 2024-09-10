using System;
using System.Collections.Generic;

namespace Curso_C_
{
    // Classe Livro
    public class Livro
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
        public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas)
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
        private List<Livro> acervo = new List<Livro>();

        // Método para adicionar um livro
        public void AdicionarLivro(Livro livro)
        {
            acervo.Add(livro);
        }

        // Método para remover um livro
        public void RemoverLivro(Livro livro)
        {
            acervo.Remove(livro);
        }

        // Método para buscar um livro por título
        public Livro BuscarLivroPorTitulo(string titulo)
        {
            return acervo.Find(livro => livro.Titulo == titulo);
        }

        // Método para listar todos os livros
        public void ListarLivros()
        {
            foreach (var livro in acervo)
            {
                livro.ExibirDetalhes();
            }
        }
    }

    // Classe Usuario
    public class Usuario
    {
        // Atributos privados
        private string nome;
        private string cpf;
        private List<Livro> livrosEmprestados = new List<Livro>();

        // Construtor
        public Usuario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        // Método para emprestar um livro
        public void EmprestarLivro(Livro livro, Biblioteca biblioteca)
        {
            Livro livroEmprestado = biblioteca.BuscarLivroPorTitulo(livro.Titulo);
            if (livroEmprestado != null)
            {
                livrosEmprestados.Add(livroEmprestado);
                biblioteca.RemoverLivro(livroEmprestado);
                Console.WriteLine($"{nome} emprestou o livro '{livro.Titulo}'.");
            }
        }

        // Método para devolver um livro
        public void DevolverLivro(Livro livro, Biblioteca biblioteca)
        {
            if (livrosEmprestados.Contains(livro))
            {
                livrosEmprestados.Remove(livro);
                biblioteca.AdicionarLivro(livro);
                Console.WriteLine($"{nome} devolveu o livro '{livro.Titulo}'.");
            }
        }

        // Método para exibir livros emprestados
        public void ExibirLivrosEmprestados()
        {
            Console.WriteLine($"Livros emprestados por {nome}:");
            foreach (var livro in livrosEmprestados)
            {
                livro.ExibirDetalhes();
            }
        }
    }

}