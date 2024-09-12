

//_010_Estrutura_Repeticao.DemonstracaoDeEstruturaRepeticao();
//_008_Conversao.DemonstracaoDeConversoes();

//______________________________________________________________________________________________________________________________________________-//
//_006_Operadores_Comparacao.DemonstrandoOperadores();

//______________________________________________________________________________________________________________________________________________-//
//bool resultado;
//resultado  = _003_Operadores_Logicos.ELogico(false, true);
//Console.WriteLine($"o resultado do operador logico e{resultado}");
//resultado = _003_Operadores_Logicos.OULogico(false, true);
//Console.WriteLine($"o resultado do operador logico OU{resultado}");
//resultado = _003_Operadores_Logicos.Negacao(true);
//Console.WriteLine($"o resultado do operador logico !{resultado}");
//resultado = _003_Operadores_Logicos.OUExclusive(false, true);
//Console.WriteLine($"o resultado do operador logico OUExclusivo{resultado}");

//______________________________________________________________________________________________________________________________________________-//
// Chamando os métodos da classe Operadores_Aritimeticos
// Operadores_Aritimeticos.Soma();
//Operadores_Aritimeticos.Subtração();
// Operadores_Aritimeticos.Divisão();
//Operadores_Aritimeticos.Multiplicação();
//Operadores_Aritimeticos.Resto();
//Operadores_Aritimeticos.Incremento();
//Operadores_Aritimeticos.Decremento();

//______________________________________________________________________________________________________________________________________________-//
/*
// 1. Criando Objetos (Instanciando a classe Pessoa)
Pessoa pessoa1 = new Pessoa("Alice", 30);
Pessoa pessoa2 = new Pessoa("Bob", 25);
Pessoa pessoa3 = new Pessoa("sarah", 29);

// 2. Usando Métodos de Instância (Métodos não estáticos)
pessoa1.ExibirInformacoes();
pessoa2.ExibirInformacoes();
pessoa3.ExibirInformacoes();

// 3. Usando Método Estático (Pertence à Classe, não à instância)
Pessoa.ExibirNumeroDePessoas();

// 4. Membros de Instância vs. Membros Estáticos
Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");//membro de estancia
Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
Console.WriteLine($"Pessoa3: {pessoa3.Nome}, Idade: {pessoa3.Idade}");
Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");//membro estatico
*/
//________________________________________________________________________________________________________________________________________________//
// Instanciando a classe Produto usando o construtor padrão
//Produto produto1 = new Produto();
//produto1.ExibirInformacoes();

// Instanciando a classe Produto usando o construtor com parâmetros
//Produto produto2 = new Produto("Smartphone", 1999.99m, 50);
//produto2.ExibirInformacoes();

// Modificando atributos usando propriedades
//produto1.Nome = "Notebook";
//produto1.Preco = 2999.99m;
//produto1.Estoque = 25;
//produto1.ExibirInformacoes();

// Acessando método protegido através da classe derivada
//ProdutoEspecial produtoEspecial = new ProdutoEspecial();
//produtoEspecial.ExibirMetodoProtegido();

//________________________________________________________________________________________________________________________________________________//

/*Livro lv = new Livro ("Coraline", "Sidney Shadow", 2009, 400);
lv.ExibirDetalhes(); */

//______________________________________________________________________________________________________________________________________________-//
/*
Carro carro = new carro("Toyota", "Civic", 2024);
carro.ExibirDetalhes();
/*Carro.Modelo = "Corolla"
carro.marca = "Toyota"
Carro.Ano.
//______________________________________________________________________________________________________________________________________________-//

Exercicio exercicio = new Exercicio();
exercicio.Exebir();
int recebeSoma = exercicio.Soma(9, 1);
Console.WriteLine($"A soma recebe dois numeros e {recebeSoma}");
//______________________________________________________________________________________________________________________________________________-//
bool recebeBool = Exercicio.MostarBolean();
Console.WriteLine($"esta chovendo {recebeBool}");
*/
//______________________________________________________________________________________________________________________________________________-//
/*bool recebeBool = Exercicio.verificarMaiorIdade(18);
Console.WriteLine($"essa pessoa e maior de idade{recebeBool}");
*/
//______________________________________________________________________________________________________________________________________________-//
/*xercicio.ExibirAltura();*/
//______________________________________________________________________________________________________________________________________________-//
/*double recebeArea = Exercicio.CalcularArea(9.45);
Console.WriteLine($"a area do circulo e igual a {recebeArea}")
*/
//______________________________________________________________________________________________________________________________________________-//
/*double recebeArea = Exercicio.CalcularArea(9.45);
Console.WriteLine($"a area do retangulo e igual a {recebeArea}")
*/
//______________________________________________________________________________________________________________________________________________-//
/*Calculadora cal = new Calculadora();
double.receberCal =  cal.Multiplicar (2, 3);
Console.WriteLine($"O valor da multiplicação com dois paramerametros {receberCal}");
double.receberCal = cal.Multiplicar(2, 3, 4);
Console.WriteLine($"O valor da multiplicação com tres paramerametros{receberCal}");
*/
//______________________________________________________________________________________________________________________________________________-//
//Exercicio.ExebirChar();
//______________________________________________________________________________________________________________________________________________-//
/*Exercicio.exebirChar();

FluxoLoop fl = new FluxoLoop();
fl.ExibirLoop();
fl.ExibirLoopWhile();
fl.ImprimirPares(6);
*/
//______________________________________________________________________________________________________________________________________________-//
//VarUsageExample example = new VarUsageExample();
//example.DemonstrateVarUsage();

//______________________________________________________________________________________________________________________________________________-//
//var exemplo = new ExemploUsoDynamic();
//exemplo.DemonstrarUsoDynamic();

//______________________________________________________________________________________________________________________________________________-//
//var exemplo = new ExemploUsoLINQ();
//exemplo.DemonstrarUsoLINQ();
//______________________________________________________________________________________________________________________________________________-//
//var Pessoa = new Exercicio();
//Pessoa.Seila();

// Criar uma instância da classe Exercicio e chamar o método Seila
// var Exercicio = new Exercicio();
//exercicio.Seila();
//______________________________________________________________________________________________________________________________________________-//
//var str = new Ponto();
//str.Ponto();
//______________________________________________________________________________________________________________________________________________-//

// Criando uma instância da struct Ponto
//Ponto ponto1 = new Ponto(3, 4);
//Ponto ponto2 = new Ponto(6, 8);

// Exibindo os detalhes dos pontos
//ponto1.ExibirDetalhes();
//ponto2.ExibirDetalhes();

// Calculando e exibindo a distância entre dois pontos
//double distancia = ponto1.CalcularDistancia(ponto2);
//Console.WriteLine($"Distância entre os pontos: {distancia}");
//______________________________________________________________________________________________________________________________________________-//
//var nulo = new NullableTypesDemo();
//nulo.ExibirValores();
//nulo.ExplicarConceitos();
//______________________________________________________________________________________________________________________________________________-//
//var stru = new ExplicacaoStructs();
//stru.DemonstrarDiferenca();
//______________________________________________________________________________________________________________________________________________-//
/*sing Curso_C_;
using System;
using System.Collections.Generic;

namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            if (!int.TryParse(Console.ReadLine(), out int ano))
            {
                Console.WriteLine("\nAno inválido.");
                return;
            }
            Console.Write("Digite o número de páginas: ");
            if (!int.TryParse(Console.ReadLine(), out int paginas))
            {
                Console.WriteLine("\nNúmero de páginas inválido.");
                return;
            }

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            if (!int.TryParse(Console.ReadLine(), out int ano))
            {
                Console.WriteLine("\nAno inválido.");
                return;
            }
            Console.Write("Digite a quilometragem do veículo: ");
            if (!int.TryParse(Console.ReadLine(), out int quilometragem))
            {
                Console.WriteLine("\nQuilometragem inválida.");
                return;
            }

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}
*/
//______________________________________________________________________________________________________________________________________________-//
/*using static Curso_C_.Paradigmas00._003_ClasseAbstrata;//pai vai salvar o nome do filho //to metodo de uma interface e abstrato 

AnimalAbs cachorro = new CachorroAbs("Billy");//classe abstrata e obrigada a botar uma abstração mas filho que tem que responder 
AnimalAbs gato = new GatoAbs("GATO");//na clase abstrata ela pode ter metodos abstratos e metodos comuns

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();*/
//______________________________________________________________________________________________________________________________________________-//
// Criando instâncias de classes que implementam a interface
/*using static Curso_C_.Paradigmas00._002_Interface;

IAnimal cachorro = new CachorroInter("Wall-e");//aqui os filhos que alimentam o pai e da dados para o pai
IAnimal gato = new GatoInter("GATO");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();
*/
//______________________________________________________________________________________________________________________________________________-//
