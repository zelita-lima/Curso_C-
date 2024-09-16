using System;
using System.Collections.Generic;

namespace Curso_C_
{
        // Classe Livro
        public class Livro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Ano { get; set; }
            public int Paginas { get; set; }

            public Livro() { } // Construtor padrão necessário para deserialização

            public Livro(string titulo, string autor, int ano, int paginas)
            {
                Titulo = titulo;
                Autor = autor;
                Ano = ano;
                Paginas = paginas;
            }

            public void ExibirDetalhes()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}, Páginas: {Paginas}");
            }
        }

        // Classe Biblioteca
        public class Biblioteca
        {
            private List<Livro> acervo = new List<Livro>();

            public void AdicionarLivro(Livro livro)
            {
                acervo.Add(livro);
            }

            public void RemoverLivro(Livro livro)
            {
                acervo.Remove(livro);
            }

            public Livro BuscarLivroPorTitulo(string titulo)
            {
                return acervo.FirstOrDefault(livro => livro.Titulo == titulo);
            }

            public List<Livro> ObterLivros()
            {
                return new List<Livro>(acervo);
            }
        }

        // Classe Usuario
        public class Usuario
        {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public List<Livro> LivrosEmprestados { get; set; } = new List<Livro>();

            public Usuario() { } // Construtor padrão necessário para deserialização

            public Usuario(string nome, string cpf)
            {
                Nome = nome;
                Cpf = cpf;
            }

            public void EmprestarLivro(Livro livro, Biblioteca biblioteca)
            {
                Livro livroEmprestado = biblioteca.BuscarLivroPorTitulo(livro.Titulo);
                if (livroEmprestado != null)
                {
                    LivrosEmprestados.Add(livroEmprestado);
                    biblioteca.RemoverLivro(livroEmprestado);
                    Console.WriteLine($"{Nome} emprestou o livro '{livro.Titulo}'.");
                }
            }

            public void DevolverLivro(Livro livro, Biblioteca biblioteca)
            {
                if (LivrosEmprestados.Contains(livro))
                {
                    LivrosEmprestados.Remove(livro);
                    biblioteca.AdicionarLivro(livro);
                    Console.WriteLine($"{Nome} devolveu o livro '{livro.Titulo}'.");
                }
            }

            public void ExibirLivrosEmprestados()
            {
                Console.WriteLine($"Livros emprestados por {Nome}:");
                foreach (var livro in LivrosEmprestados)
                {
                    livro.ExibirDetalhes();
                }
            }
        }

        // Classe Emprestimo
        public class Emprestimo
        {
            public string UsuarioCpf { get; set; }
            public string LivroTitulo { get; set; }
            public DateTime DataEmprestimo { get; set; }
        }

        // Classe Dados para deserialização
        public class Dados
        {
            public List<Usuario> Usuarios { get; set; }
            public List<Livro> Livros { get; set; }
            public List<Emprestimo> Emprestimos { get; set; }
        }
    }
