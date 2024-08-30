using Curso_C_;


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
    var Exercicio = new Exercicio();
    exercicio.Seila();

