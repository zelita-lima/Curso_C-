using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    internal class Exeecicio_Padaria
    {
        // Classe base Produto
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int QuantidadeEstoque { get; set; }

            // Construtor da classe base
            public Produto(string nome, decimal preco, int quantidadeEstoque)
            {
                Nome = nome;
                Preco = preco;
                QuantidadeEstoque = quantidadeEstoque;
            }

            // Método para exibir detalhes do produto
            public virtual void ExibirDetalhes()
            {
                Console.WriteLine($"{Nome} - Preço: {Preco:C} - Estoque: {QuantidadeEstoque}");
            }

            // Método para atualizar o estoque
            public void AtualizarEstoque(int quantidade)
            {
                QuantidadeEstoque += quantidade;
            }

            // Método para verificar se há estoque suficiente
            public bool TemEstoqueSuficiente(int quantidade)
            {
                return QuantidadeEstoque >= quantidade;
            }
        }

        // Classe derivada Pao que herda de Produto
        public class Pao : Produto
        {
            public Pao(string nome, decimal preco, int quantidadeEstoque) : base(nome, preco, quantidadeEstoque)
            {
            }

            // Sobrescrevendo o método ExibirDetalhes
            public override void ExibirDetalhes()
            {
                Console.WriteLine($"Pão: {Nome} - Preço: {Preco:C} - Estoque: {QuantidadeEstoque}");
            }
        }

        // Classe derivada Bolo que herda de Produto
        public class Bolo : Produto
        {
            public Bolo(string nome, decimal preco, int quantidadeEstoque) : base(nome, preco, quantidadeEstoque)
            {
            }

            // Sobrescrevendo o método ExibirDetalhes
            public override void ExibirDetalhes()
            {
                Console.WriteLine($"Bolo: {Nome} - Preço: {Preco:C} - Estoque: {QuantidadeEstoque}");
            }
        }

        // Classe Venda
        public class Venda
        {
            public List<Produto> ProdutosVendidos { get; private set; } = new List<Produto>();
            public decimal Total { get; private set; }

            // Método para adicionar um produto à venda
            public void AdicionarProduto(Produto produto, int quantidade)
            {
                if (produto.TemEstoqueSuficiente(quantidade))
                {
                    produto.QuantidadeEstoque -= quantidade;
                    ProdutosVendidos.Add(produto);
                    Total += produto.Preco * quantidade;
                    Console.WriteLine($"{quantidade} unidade(s) de {produto.Nome} vendido(s).");
                }
                else
                {
                    Console.WriteLine($"Estoque insuficiente para {produto.Nome}.");
                }
            }

            // Método para exibir o resumo da venda
            public void ExibirResumo()
            {
                Console.WriteLine("\nResumo da Venda:");
                foreach (var produto in ProdutosVendidos)
                {
                    Console.WriteLine($"{produto.Nome} - Preço: {produto.Preco:C}");
                }
                Console.WriteLine($"Total: {Total:C}");
            }
        }

        // Classe para gerenciar a padaria
        public class GerenciadorPadaria
        {
            public List<Produto> Produtos { get; private set; } = new List<Produto>();

            // Método para adicionar um produto ao estoque
            public void AdicionarProduto(Produto produto)
            {
                Produtos.Add(produto);
            }

            // Método para exibir todos os produtos
            public void ExibirProdutos()
            {
                Console.WriteLine("\nProdutos da Padaria:");
                foreach (var produto in Produtos)
                {
                    produto.ExibirDetalhes();
                }
            }
        }

       
    }
}

