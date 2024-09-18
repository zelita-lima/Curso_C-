using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SistemaGerenciamentoPadaria
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<Venda> vendas = new List<Venda>();

        static string caminhoProdutos = @"C:\Users\Aluno Noite\Desktop\Curso_C-\produtos.json"; // Caminho para o arquivo produtos.json
        static string caminhoClientes = @"C:\Users\Aluno Noite\Desktop\Curso_C-\clientes.json"; // Caminho para o arquivo clientes.json
        static string caminhoVendas = @"C:\Users\Aluno Noite\Desktop\Curso_C-\vendas.json"; // Caminho para o arquivo vendas.json

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║                 SITEMA DE GENCIAMENTO                 ║");
                Console.WriteLine("║                       DE PADARIA                      ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Gerenciar Produtos                                  ║");
                Console.WriteLine("║2. Gerenciar Clientes                                  ║");
                Console.WriteLine("║3. Gerenciar Vendas                                    ║");
                Console.WriteLine("║4. Gerenciar Estoque                                   ║");
                Console.WriteLine("║5. Gerar Relatorio                                     ║");
                Console.WriteLine("║0. Sair                                                ║");
                Console.WriteLine($"║Autor: Zelita Lima                                     ║");
                Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuProdutos();
                        break;
                    case 2:
                        MenuClientes();
                        break;
                    case 3:
                        MenuVendas();
                        break;
                    case 4:
                        GerenciarEstoque();
                        break;
                    case 5:
                        GerarRelatorio();
                        break;
                    case 0:
                        SalvarDados();
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }


        static void GerarRelatorio()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                              RELATÓRIO GERAL                                           ║");
                Console.WriteLine("║                                                DA PADARIA                                              ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                                                           ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                // Cabeçalhos da tabela
                Console.WriteLine("╔════════╦═════════════════════╦════════════╦═════════════════╦══════════════════════╦═══════════════════╗");
                Console.WriteLine("║  ID    ║  Nome do Produto    ║  Preço     ║  Quantidade     ║  Nome do Cliente     ║  Data da Venda    ║");
                Console.WriteLine("╠════════╬═════════════════════╬════════════╬═════════════════╬══════════════════════╬═══════════════════╣");

                // Dados dos produtos, clientes e vendas (simulando uma lista de vendas)
                foreach (var venda in vendas)
                {
                    Console.WriteLine($"║  {venda.Id,-3}   ║  {venda.Produto.Nome,-15}    ║  R${venda.Produto.Preco,-8}║  {venda.Produto.Quantidade,-10}     ║  {venda.Cliente.Nome,-15}     ║  {venda.Data:dd/MM/yyyy,-14}   ║");
                }

                // Linha de rodapé
                Console.WriteLine("╚════════╩═════════════════════╩════════════╩═════════════════╩══════════════════════╩═══════════════════╝");

                // Menu para sair ou continuar
                Console.WriteLine("\nDigite 0 para sair ou qualquer outro número para gerar o relatório novamente.");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1; // Caso a entrada seja inválida, continua o loop
                }
            } while (opcao != 0);
        }





        // Menu Produtos
        static void MenuProdutos()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║             GERENCIAR PRODUTOS DA PADARIA             ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Adicionar Produto                                   ║");
                Console.WriteLine("║2. Listar Produtos                                     ║");
                Console.WriteLine("║3. Atualizar Produto                                   ║");
                Console.WriteLine("║4. Remover Produto                                     ║");
                Console.WriteLine("║0. Voltar                                              ║");
                Console.WriteLine($"║Autor: Zelita Lima                                     ║");
                Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

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

        // Funções de Gerenciamento de Produtos
        static void AdicionarProduto()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 ADICIONAR NOVO PRODUTO                ║");
            Console.WriteLine("║                    PARA A PADARIA                     ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            while (!ValidarTexto(nome))
            {
                Console.Write("Erro: nome do produto deve conter apenas texto. Tente novamente: ");
                nome = Console.ReadLine();
            }

            Console.Write("Digite o preço do produto: ");
            string precoStr = Console.ReadLine();

            while (!ValidarNumero(precoStr))
            {
                Console.Write("Erro: preço do produto deve conter apenas números. Tente novamente: ");
                precoStr = Console.ReadLine();
            }

            decimal preco = decimal.Parse(precoStr);

            Console.Write("Digite a quantidade inicial no estoque: ");
            string quantidadeStr = Console.ReadLine();

            while (!ValidarNumero(quantidadeStr))
            {
                Console.Write("Erro: quantidade inicial no estoque deve conter apenas números. Tente novamente: ");
                quantidadeStr = Console.ReadLine();
            }

            int quantidade = int.Parse(quantidadeStr);

            int id = produtos.Count > 0 ? produtos[^1].Id + 1 : 1;
            Produto produto = new Produto(id, nome, preco, quantidade);
            produtos.Add(produto);

            Console.WriteLine("\nProduto adicionado com sucesso!");
            SalvarDados();
        }
        static void ListarProdutos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                            LISTA DE PRODUTO                         ║");
            Console.WriteLine("║                               NA PADARIA                            ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                       ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            if (produtos.Count == 0)
            {
                Console.WriteLine("\nNenhum produto cadastrado.");
            }
            else
            {
                // Cabeçalhos da tabela
                Console.WriteLine("╔══════════╦══════════════════════════╦═══════════════╦═══════════════╗");
                Console.WriteLine("║   ID     ║   Nome                   ║  Preço        ║   Estoque     ║");
                Console.WriteLine("╠══════════╬══════════════════════════╬═══════════════╬═══════════════╣");

                // Dados dos produtos
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"║  {produto.Id,-3}     ║ {produto.Nome,-20}     ║ R${produto.Preco,-8}    ║ {produto.Quantidade,-10}    ║");
                }

                // Linha de rodapé
                Console.WriteLine("╚══════════╩══════════════════════════╩═══════════════╩═══════════════╝");
            }
        }



        static void AtualizarProduto()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  ATUALIZAR PRODUTOS                   ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o ID do produto a ser atualizado: ");
            string idStr = Console.ReadLine();

            while (!ValidarNumero(idStr))
            {
                Console.Write("Erro: ID do produto deve conter apenas números. Tente novamente: ");
                idStr = Console.ReadLine();
            }

            int id = int.Parse(idStr);

            var produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                Console.Write("Digite o novo nome do produto: ");
                string nome = Console.ReadLine();

                while (!ValidarTexto(nome))
                {
                    Console.Write("Erro: nome do produto deve conter apenas texto. Tente novamente: ");
                    nome = Console.ReadLine();
                }

                produto.Nome = nome;

                Console.Write("Digite o novo preço do produto: ");
                string precoStr = Console.ReadLine();

                while (!ValidarNumero(precoStr))
                {
                    Console.Write("Erro: preço do produto deve conter apenas números. Tente novamente: ");
                    precoStr = Console.ReadLine();
                }

                produto.Preco = decimal.Parse(precoStr);

                Console.WriteLine("\nProduto atualizado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        static void RemoverProduto()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   REMOVER PRODUTOS                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o ID do produto a ser removido: ");
            string idStr = Console.ReadLine();

            while (!ValidarNumero(idStr))
            {
                Console.Write("Erro: ID do produto deve conter apenas números. Tente novamente: ");
                idStr = Console.ReadLine();
            }

            int id = int.Parse(idStr);

            var produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("\nProduto removido com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        // Menu Clientes
        static void MenuClientes()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║                  GERENCIAR CLIENTES                   ║");
                Console.WriteLine("║                      DA PADARIA                       ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Adicionar Cliente                                   ║");
                Console.WriteLine("║2. Listar Clientes                                     ║");
                Console.WriteLine("║3. Atualizar Cliente                                   ║");
                Console.WriteLine("║4. Remover Cliente                                     ║");
                Console.WriteLine("║0. Voltar                                              ║");
                Console.WriteLine($"║Autor: Zelita Lima                                     ║");
                Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        AtualizarCliente();
                        break;
                    case 4:
                        RemoverCliente();
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

        // Funções de Gerenciamento de Clientes
        static void AdicionarCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║              ADICIONAR NOVOS CLIENTES                 ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            while (!ValidarTexto(nome))
            {
                Console.Write("Erro: nome do cliente deve conter apenas texto. Tente novamente: ");
                nome = Console.ReadLine();
            }

            int id = clientes.Count > 0 ? clientes[^1].Id + 1 : 1;
            Cliente cliente = new Cliente(id, nome);
            clientes.Add(cliente);

            Console.WriteLine("\nCliente adicionado com sucesso!");
            SalvarDados();
        }

        static void ListarClientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                           LISTA DE CLIENTES                        ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                       ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }
            else
            {
                // Cabeçalhos da tabela
                Console.WriteLine("╔═════════╦══════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ ID      ║ Nome                                                     ║");
                Console.WriteLine("╠═════════╬══════════════════════════════════════════════════════════╣");

                // Dados dos clientes
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"║ {cliente.Id,-3}     ║ {cliente.Nome,-28}                             ║");
                }

                // Linha de rodapé
                Console.WriteLine("╚═════════╩══════════════════════════════════════════════════════════╝");
            }
        }




        static void AtualizarCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  ATUALIZAR CLIENTES                   ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o ID do cliente a ser atualizado: ");
            string idStr = Console.ReadLine();

            while (!ValidarNumero(idStr))
            {
                Console.Write("Erro: ID do cliente deve conter apenas números. Tente novamente: ");
                idStr = Console.ReadLine();
            }

            int id = int.Parse(idStr);

            var cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                Console.Write("Digite o novo nome do cliente: ");
                string nome = Console.ReadLine();

                while (!ValidarTexto(nome))
                {
                    Console.Write("Erro: nome do cliente deve conter apenas texto. Tente novamente: ");
                    nome = Console.ReadLine();
                }

                cliente.Nome = nome;

                Console.WriteLine("\nCliente atualizado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nCliente não encontrado.");
            }
        }

        static void RemoverCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   REMOVER CLIENTES                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o ID do cliente a ser removido: ");
            string idStr = Console.ReadLine();

            while (!ValidarNumero(idStr))
            {
                Console.Write("Erro: ID do cliente deve conter apenas números. Tente novamente: ");
                idStr = Console.ReadLine();
            }

            int id = int.Parse(idStr);

            var cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("\nCliente removido com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nCliente não encontrado.");
            }
        }

        // Menu Vendas
        static void MenuVendas()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║                   GERENCIAR VENDAS                    ║");
                Console.WriteLine("║                      DA PADARIA                       ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Registrar Venda                                     ║");
                Console.WriteLine("║2. Listar Vendas                                       ║");
                Console.WriteLine("║0. Voltar                                              ║");
                Console.WriteLine($"║Autor: Zelita Lima                                     ║");
                Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

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

        // Funções de Gerenciamento de Vendas
        static void RegistrarVenda()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║               REGISTRAR NOVAS VENDAS                  ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            ListarClientes();
            Console.Write("\nDigite o ID do cliente: ");
            string clienteIdStr = Console.ReadLine();

            while (!ValidarNumero(clienteIdStr))
            {
                Console.Write("Erro: ID do cliente deve conter apenas números. Tente novamente: ");
                clienteIdStr = Console.ReadLine();
            }

            int clienteId = int.Parse(clienteIdStr);

            var cliente = clientes.Find(c => c.Id == clienteId);

            if (cliente == null)
            {
                Console.WriteLine("\nCliente não encontrado.");
                return;
            }

            ListarProdutos();
            Console.Write("\nDigite o ID do produto: ");
            string produtoIdStr = Console.ReadLine();

            while (!ValidarNumero(produtoIdStr))
            {
                Console.Write("Erro: ID do produto deve conter apenas números. Tente novamente: ");
                produtoIdStr = Console.ReadLine();
            }

            int produtoId = int.Parse(produtoIdStr);

            var produto = produtos.Find(p => p.Id == produtoId);

            if (produto == null)
            {
                Console.WriteLine("\nProduto não encontrado.");
                return;
            }

            Console.Write("Digite a quantidade vendida: ");
            string quantidadeVendidaStr = Console.ReadLine();

            while (!ValidarNumero(quantidadeVendidaStr))
            {
                Console.Write("Erro: quantidade vendida deve conter apenas números. Tente novamente: ");
                quantidadeVendidaStr = Console.ReadLine();
            }

            int quantidadeVendida = int.Parse(quantidadeVendidaStr);

            if (quantidadeVendida > produto.Quantidade)
            {
                Console.WriteLine("\nQuantidade insuficiente no estoque.");
                return;
            }

            produto.Quantidade -= quantidadeVendida;

            int id = vendas.Count > 0 ? vendas[^1].Id + 1 : 1;
            Venda venda = new Venda(id, cliente, produto, quantidadeVendida, DateTime.Now);
            vendas.Add(venda);

            Console.WriteLine("\nVenda registrada com sucesso!");
            SalvarDados();
        }
        static void ListarVendas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                              LISTA DE VENDAS                           ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            if (vendas.Count == 0)
            {
                Console.WriteLine("\nNenhuma venda registrada.");
            }
            else
            {
                // Cabeçalhos da tabela
                Console.WriteLine("╔═════╦════════════════╦═══════════════════╦════════════╦════════════════╗");
                Console.WriteLine("║ ID  ║ Cliente        ║ Produto           ║ Quantidade ║ Data           ║");
                Console.WriteLine("╠═════╬════════════════╬═══════════════════╬════════════╬════════════════╣");

                // Dados das vendas
                foreach (var venda in vendas)
                {
                    Console.WriteLine($"║{venda.Id,-3}  ║{venda.Cliente.Nome,-15} ║ {venda.Produto.Nome,-17} ║ {venda.Quantidade,-10} ║ {venda.Data:dd/MM/yyyy,-14} ║");
                }

                // Linha de rodapé
                Console.WriteLine("╚═════╩════════════════╩═══════════════════╩════════════╩════════════════╝");
            }
        }


        // Funções de Gerenciamento de Estoque
        static void GerenciarEstoque()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   GERENCIAR ESTOQUE                   ║");
            Console.WriteLine("║                      DA PADARIA                       ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            ListarProdutos();

            Console.Write("\nDigite o ID do produto para atualizar o estoque: ");
            string produtoIdStr = Console.ReadLine();

            while (!ValidarNumero(produtoIdStr))
            {
                Console.Write("Erro: ID do produto deve conter apenas números. Tente novamente: ");
                produtoIdStr = Console.ReadLine();
            }

            int produtoId = int.Parse(produtoIdStr);

            var produto = produtos.Find(p => p.Id == produtoId);

            if (produto == null)
            {
                Console.WriteLine("\nProduto não encontrado.");
                return;
            }

            Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
            string quantidadeAdicionadaStr = Console.ReadLine();

            while (!ValidarNumero(quantidadeAdicionadaStr))
            {
                Console.Write("Erro: quantidade a ser adicionada ao estoque deve conter apenas números. Tente novamente: ");
                quantidadeAdicionadaStr = Console.ReadLine();
            }

            int quantidadeAdicionada = int.Parse(quantidadeAdicionadaStr);

            produto.Quantidade += quantidadeAdicionada;

            Console.WriteLine("\nEstoque atualizado com sucesso!");
            SalvarDados();
        }

        // Funções de Salvamento e Carregamento de Dados
        static void SalvarDados()
        {
            File.WriteAllText(caminhoProdutos, JsonSerializer.Serialize(produtos));
            File.WriteAllText(caminhoClientes, JsonSerializer.Serialize(clientes));
            File.WriteAllText(caminhoVendas, JsonSerializer.Serialize(vendas));
        }

        static void CarregarDados()
        {
            if (File.Exists(caminhoProdutos))
            {
                produtos = JsonSerializer.Deserialize<List<Produto>>(File.ReadAllText(caminhoProdutos));
            }

            if (File.Exists(caminhoClientes))
            {
                clientes = JsonSerializer.Deserialize<List<Cliente>>(File.ReadAllText(caminhoClientes));
            }

            if (File.Exists(caminhoVendas))
            {
                vendas = JsonSerializer.Deserialize<List<Venda>>(File.ReadAllText(caminhoVendas));
            }
        }

        static bool ValidarTexto(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidarNumero(string numero)
        {
            foreach (char c in numero)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

    // Classe Produto
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, decimal preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }

    // Classe Cliente
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    // Classe Venda
    class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }

        public Venda(int id, Cliente cliente, Produto produto, int quantidade, DateTime data)
        {
            Id = id;
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            Data = data;
        }
    }
}