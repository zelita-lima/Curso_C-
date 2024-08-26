using System;

namespace CursoCSharp
{
    // Definição da classe Produto
    public class Produto
    {
        // Atributos privados (encapsulamento)
        private string nome;
        private decimal preco;
        private int estoque;

        // Construtor padrão
        public Produto()//não leva parametro
        {
            nome = "Produto Padrão";
            preco = 0.0m;
            estoque = 0;
        }

        // Construtor com parâmetros (Sobrecarga de Construtores)
        public Produto(string nome, decimal preco, int estoque)//asinatura do metodo// espera parametro
        {
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }

        // Propriedades (Getters e Setters) para encapsular os campos privados
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    Console.WriteLine("O preço deve ser positivo.");
                }
            }
        }

        public int Estoque
        {
            get { return estoque; }
            set
            {
                if (value >= 0)
                {
                    estoque = value;
                }
                else
                {
                    Console.WriteLine("O estoque não pode ser negativo.");
                }
            }
        }

        // Método para exibir informações do produto
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}, Preço: {preco:C}, Estoque: {estoque} unidades");
        }

        // Método privado que só pode ser acessado dentro da classe
        private void MetodoPrivado()
        {
            Console.WriteLine("Este é um método privado.");
        }

        // Método protegido que pode ser acessado em classes derivadas
        protected void MetodoProtegido()
        {
            Console.WriteLine("Este é um método protegido.");
        }
    }

    // Classe derivada de Produto
    public class ProdutoEspecial : Produto//dois pontos e igual herança
    {
        // Método que acessa o método protegido da classe base
        public void ExibirMetodoProtegido()
        {
            MetodoProtegido();
        }
    }

    }
