using System;
using System.Dynamic;

namespace CursoCSharp
 {
    public class Veiculo
    {
        public string marca {get; set;}
        public string modelo {get; set;}
        public int ano {get; set;}
        public int velocimetero {get; set;}

        public Veiculo( string marca, string modelo, int ano ,int velocimetero)
        {
            this.marca = marca; 
            this.modelo = modelo;  
            this.ano = ano; 
            this.velocimetero = velocimetero; 
        }

         public void ExibirDetalhes()
        {
            Console.WriteLine($"O nome do livro é: {this.marca}, o autor do livro é: {this.modelo}, o ano de publicaçaõ: {this.ano}, a quantidade de páginas é: {this.velocimetesro}");
        } 
    }
 }