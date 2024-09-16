

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
/*using static Curso_C_.Paradigmas00._001_Plimorfismo;

var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
exp.ExplicarPolimorfismo();
*/
//______________________________________________________________________________________________________________________________________________-//
/*using Curso_C_;
using System.Text.Json;

namespace BibliotecaVeiculos
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Biblioteca biblioteca = new Biblioteca();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca();
                        break;
                    case 2:
                        MenuUsuarios();
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

        static void MenuBiblioteca()
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
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        biblioteca.ObterLivros().ForEach(livro => livro.ExibirDetalhes());
                        break;
                    case 3:
                        EmprestarLivro();
                        break;
                    case 4:
                        DevolverLivro();
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

        static void MenuUsuarios()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR USUÁRIOS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Remover Usuário");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        RemoverUsuario();
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

        static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO USUÁRIO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do usuário: ");
            string cpf = Console.ReadLine();

            // Verificar se o CPF já existe
            if (usuarios.Any(u => u.Cpf == cpf))
            {
                Console.WriteLine("\nUsuário com este CPF já existe.");
                return;
            }

            Usuario usuario = new Usuario(nome, cpf);
            usuarios.Add(usuario);
            Console.WriteLine("\nUsuário adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarUsuarios();
        }

        static void ListarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Usuarios.json";
            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Usuarios != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE USUÁRIOS CADASTRADOS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Usuarios.Count == 0)
                        {
                            Console.WriteLine("\nNenhum usuário cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Usuarios.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {dados.Usuarios[i].Nome} - CPF: {dados.Usuarios[i].Cpf}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de usuários está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }
        }

        static void RemoverUsuario()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < usuarios.Count)
            {
                usuarios.RemoveAt(indice);
                Console.WriteLine("\nUsuário removido com sucesso!");
                SalvarUsuarios(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void AdicionarLivro()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
            SalvarLivros(); // Atualiza o arquivo após adicionar livro
        }

        static void EmprestarLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá emprestar o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.EmprestarLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após emprestar livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void DevolverLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá devolver o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.DevolverLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após devolver livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void CarregarDados()
        {
            // Carregar usuários
            string caminhoUsuarios = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Usuarios.json";
            if (File.Exists(caminhoUsuarios))
            {
                string json = File.ReadAllText(caminhoUsuarios);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        usuarios = dados.Usuarios;
                        Console.WriteLine("Usuários carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos usuários: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de usuários não encontrado.");
            }

            // Carregar livros
            string caminhoLivros = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Usuarios.json";
            if (File.Exists(caminhoLivros))
            {
                string json = File.ReadAllText(caminhoLivros);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        biblioteca = new Biblioteca();
                        foreach (var livro in dados.Livros)
                        {
                            biblioteca.AdicionarLivro(livro);
                        }
                        Console.WriteLine("Livros carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos livros: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de livros não encontrado.");
            }

            // Carregar empréstimos (se necessário para inicializar estado)
            string caminhoEmprestimos = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Usuarios.json";
            if (File.Exists(caminhoEmprestimos))
            {
                string json = File.ReadAllText(caminhoEmprestimos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null && dados.Emprestimos != null)
                    {
                        foreach (var emprestimo in dados.Emprestimos)
                        {
                            // Aqui você pode adicionar lógica para processar empréstimos carregados
                        }
                        Console.WriteLine("Empréstimos carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos empréstimos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de empréstimos não encontrado.");
            }
        }

        static void SalvarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Usuarios.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = usuarios,
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Usuários salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar usuários: {ex.Message}");
            }
        }

        static void SalvarLivros()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Livros.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = biblioteca.ObterLivros(),
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Livros salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar livros: {ex.Message}");
            }
        }

        static void SalvarEmprestimos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Emprestimo.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = usuarios.SelectMany(u => u.LivrosEmprestados.Select(l => new Emprestimo
                    {
                        UsuarioCpf = u.Cpf,
                        LivroTitulo = l.Titulo,
                        DataEmprestimo = DateTime.Now // Aqui seria ideal colocar a data real do empréstimo
                    })).ToList()
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Empréstimos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar empréstimos: {ex.Message}");
            }
        }

        static void SalvarDados()
        {
            SalvarUsuarios();
            SalvarEmprestimos();
            SalvarLivros();
        }
    }

    public class Dados
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Livro> Livros { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}
*/
//______________________________________________________________________________________________________________________________________________-//
/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Padaria
{
    class Program
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

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

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
                Console.WriteLine("3. Atualizar Estoque");
                Console.WriteLine("4. Remover Produto");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
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
                        AtualizarEstoque();
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
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
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

        static void AdicionarProduto()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO PRODUTO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade em estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());

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

        static void AtualizarEstoque()
        {
            ListarProdutos();
            Console.Write("\nDigite o número do produto para atualizar o estoque: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < produtos.Count)
            {
                Console.Write("Digite a nova quantidade em estoque: ");
                int novaQuantidade = int.Parse(Console.ReadLine());
                produtos[indice].QuantidadeEstoque = novaQuantidade;
                Console.WriteLine("\nEstoque atualizado com sucesso!");
                SalvarDados(); // Atualiza o arquivo após atualizar estoque
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
            int indice = int.Parse(Console.ReadLine()) - 1;

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
                int indice = int.Parse(Console.ReadLine()) - 1;

                if (indice == -1) break;

                if (indice >= 0 && indice < produtos.Count)
                {
                    Console.Write("Digite a quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

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
            // Carregar produtos
            string caminhoProdutos = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Estoque.json";
            if (File.Exists(caminhoProdutos))
            {
                string json = File.ReadAllText(caminhoProdutos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        produtos = dados.Produtos;
                        Console.WriteLine("Produtos carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos produtos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de produtos não encontrado.");
            }

            // Carregar vendas
            string caminhoVendas = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Vendas.json";
            if (File.Exists(caminhoVendas))
            {
                string json = File.ReadAllText(caminhoVendas);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        vendas = dados.Vendas;
                        Console.WriteLine("Vendas carregadas com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON das vendas: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de vendas não encontrado.");
            }
        }

        static void SalvarDados()
        {
            SalvarProdutos();
            SalvarVendas();
        }

        static void SalvarProdutos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Produtos.json";

            try
            {
                var dados = new Dados
                {
                    Produtos = produtos,
                    Vendas = new List<Venda>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Produtos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar produtos: {ex.Message}");
            }
        }

        static void SalvarVendas()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_C-\Vendas.json";

            try
            {
                var dados = new Dados
                {
                    Produtos = new List<Produto>(), // Lista vazia
                    Vendas = vendas
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Vendas salvas com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar vendas: {ex.Message}");
            }
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto() { }

        public Produto(string nome, decimal preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }

    public class Venda
    {
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public DateTime DataVenda { get; set; } = DateTime.Now;

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            Itens.Add(new ItemVenda
            {
                Produto = produto,
                Quantidade = quantidade,
                PreçoTotal = produto.Preco * quantidade
            });
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Data da Venda: {DataVenda}");
            foreach (var item in Itens)
            {
                Console.WriteLine($"Produto: {item.Produto.Nome}, Quantidade: {item.Quantidade}, Preço Total: {item.PreçoTotal:C}");
            }
            Console.WriteLine($"Total da Venda: {Itens.Sum(i => i.PreçoTotal):C}");
        }
    }

    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PreçoTotal { get; set; }
    }

    public class Dados
    {
        public List<Produto> Produtos { get; set; }
        public List<Venda> Vendas { get; set; }
    }
}
*/
