using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Padaria
{
    static class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static List<Venda> vendas = new List<Venda>();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE PADARIA   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Produtos");
                Console.WriteLine("2. Gerenciar Vendas");
                Console.WriteLine("0. Sair");

                opcao = LerInteiro("Escolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        MenuProdutos();
                        break;
                    case 2:
                        MenuVendas();
                        break;
                    case 0:
                        SalvarDados(); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuProdutos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR PRODUTOS   ===========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Atualizar Produto");
                Console.WriteLine("4. Remover Produto");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");

                opcao = LerInteiro("Escolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 3:
                        AtualizarProduto();
                        break;
                    case 4:
                        RemoverProduto();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuVendas()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR VENDAS   =============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Registrar Venda");
                Console.WriteLine("2. Listar Vendas");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");

                opcao = LerInteiro("Escolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        RegistrarVenda();
                        break;
                    case 2:
                        ListarVendas();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarProduto()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO PRODUTO   =========");
            Console.WriteLine("==============================================");

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            double preco = LerDouble($"Digite o preço do produto: ");

            int quantidadeEstoque = LerInteiro($"Digite a quantidade em estoque: ");

            Produto produto = new Produto(nome, preco, quantidadeEstoque);
            produtos.Add(produto);
            Console.WriteLine("\nProduto adicionado com sucesso!");
            SalvarDados(); // Atualiza o arquivo após adicionar produto
        }

        static void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   LISTA DE PRODUTOS   =============");
            Console.WriteLine("==============================================");

            if (produtos.Count == 0)
            {
                Console.WriteLine("\nNenhum produto cadastrado.");
            }
            else
            {
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {produtos[i].Nome} - Preço: {produtos[i].Preco:C} - Estoque: {produtos[i].QuantidadeEstoque}");
                }
            }
        }

        static void AtualizarProduto()
        {
            ListarProdutos();
            Console.Write("\nDigite o número do produto para atualizar: ");
            int indice = LerInteiro("Digite o número do produto para atualizar: ") - 1;

            if (indice >= 0 && indice < produtos.Count)
            {
                Console.WriteLine("\nOpções de atualização:");
                Console.WriteLine("1. Atualizar Nome");
                Console.WriteLine("2. Atualizar Preço");
                Console.WriteLine("3. Atualizar Estoque");
                Console.WriteLine("4. Atualizar Tudo");

                int opcao = LerInteiro("Escolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nDigite o novo nome do produto: ");
                        produtos[indice].Nome = Console.ReadLine();
                        break;
                    case 2:
                        produtos[indice].Preco = LerDouble("\nDigite o novo preço do produto: ");
                        break;
                    case 3:
                        produtos[indice].QuantidadeEstoque = LerInteiro("\nDigite a nova quantidade em estoque: ");
                        break;
                    case 4:
                        Console.Write("\nDigite o novo nome do produto: ");
                        produtos[indice].Nome = Console.ReadLine();
                        produtos[indice].Preco = LerDouble("Digite o novo preço do produto: ");
                        produtos[indice].QuantidadeEstoque = LerInteiro("Digite a nova quantidade em estoque: ");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }

                Console.WriteLine("\nProduto atualizado com sucesso!");
                SalvarDados(); // Atualiza o arquivo após atualizar o produto
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void RemoverProduto()
        {
            ListarProdutos();
            Console.Write("\nDigite o número do produto a ser removido: ");
            int indice = LerInteiro("Digite o número do produto a ser removido: ") - 1;

            if (indice >= 0 && indice < produtos.Count)
            {
                produtos.RemoveAt(indice);
                Console.WriteLine("\nProduto removido com sucesso!");
                SalvarDados(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void RegistrarVenda()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   REGISTRAR NOVA VENDA   ===========");
            Console.WriteLine("==============================================");

            var venda = new Venda();
            ListarProdutos();

            while (true)
            {
                Console.Write("\nDigite o número do produto para adicionar à venda (ou 0 para finalizar): ");
                int indice = LerInteiro("Digite o número do produto para adicionar à venda: ") - 1;

                if (indice == -1) break;

                if (indice >= 0 && indice < produtos.Count)
                {
                    int quantidade = LerInteiro("Digite a quantidade: ");

                    var produto = produtos[indice];
                    if (produto.QuantidadeEstoque >= quantidade)
                    {
                        venda.AdicionarProduto(produto, quantidade);
                        produto.QuantidadeEstoque -= quantidade;
                    }
                    else
                    {
                        Console.WriteLine("\nEstoque insuficiente.");
                    }
                }
                else
                {
                    Console.WriteLine("\nNúmero inválido.");
                }
            }

            vendas.Add(venda);
            Console.WriteLine("\nVenda registrada com sucesso!");
            SalvarDados(); // Atualiza o arquivo após registrar venda
        }

        static void ListarVendas()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   LISTA DE VENDAS   ===============");
            Console.WriteLine("==============================================");

            if (vendas.Count == 0)
            {
                Console.WriteLine("\nNenhuma venda registrada.");
            }
            else
            {
                for (int i = 0; i < vendas.Count; i++)
                {
                    Console.WriteLine($"Venda {i + 1}:");
                    vendas[i].ExibirDetalhes();
                    Console.WriteLine();
                }
            }
        }

        static void CarregarDados()
        {
            string caminhoEstoque = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Estoque.json";
            string caminhoVendas = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Vendas.json";

            try
            {
                if (File.Exists(caminhoEstoque))
                {
                    string jsonProdutos = File.ReadAllText(caminhoEstoque);
                    produtos = JsonSerializer.Deserialize<List<Produto>>(jsonProdutos) ?? new List<Produto>();
                }

                if (File.Exists(caminhoVendas))
                {
                    string jsonVendas = File.ReadAllText(caminhoVendas);
                    vendas = JsonSerializer.Deserialize<List<Venda>>(jsonVendas) ?? new List<Venda>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar dados: {ex.Message}");
            }
        }

        static void SalvarDados()
        {
            string caminhoEstoque = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Estoque.json";
            string caminhoVendas = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Vendas.json";

            try
            {
                string jsonProdutos = JsonSerializer.Serialize(produtos);
                File.WriteAllText(caminhoEstoque, jsonProdutos);
                Console.WriteLine("Produtos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar produtos: {ex.Message}");
            }

            try
            {
                string jsonVendas = JsonSerializer.Serialize(vendas);
                File.WriteAllText(caminhoVendas, jsonVendas);
                Console.WriteLine("Vendas salvas com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar vendas: {ex.Message}");
            }
        }

        static int LerInteiro(string mensagem)
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Entrada inválida. " + mensagem);
            }
            return valor;
        }

        static double LerDouble(string mensagem)
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Entrada inválida. " + mensagem);
            }
            return valor;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }

    public class Venda
    {
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            Itens.Add(new ItemVenda { Produto = produto, Quantidade = quantidade });
        }

        public void ExibirDetalhes()
        {
            foreach (var item in Itens)
            {
                Console.WriteLine($"{item.Produto.Nome} - Quantidade: {item.Quantidade} - Total: {item.Quantidade * item.Produto.Preco:C}");
            }
        }
    }

    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}