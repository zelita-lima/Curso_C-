using System;

namespace CursoCSharp
{
  public class Livro
    {
        //Crie uma classe Livro com os atributos titulo, autor, anoPublicacao e numeroPaginas como private.
        //Implemente as propriedades public com get e set para acessar esses atributos, aplicando encapsulamento.
        private string Titulo{get; set;}
        private string Autor{get; set;} 
        private int AnoPublicacao{get; set;} 
        private int NumeroPaginas{get; set;} 
        public Livro (string titulo, string autor, int anoPublicacao, int numeroPaginas) 
        {
            this.Titulo = titulo; 
            this.Autor = autor;  
            this.AnoPublicacao = anoPublicacao; 
            this.NumeroPaginas = numeroPaginas; 
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"O nome do livro é: {this.Titulo}, o autor do livro é: {this.Autor}, o ano de publicaçaõ: {this.AnoPublicacao}, a quantidade de páginas é: {this.NumeroPaginas}");
        } 

    }
}
