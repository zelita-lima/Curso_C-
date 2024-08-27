using System;

namespace Curso_C_
{
	public class VarUsageExample
	{
		public void DemonstrateVarUsage()
		{
			// Exemplo 1: Infer�ncia de Tipo
			var NumeroInteiro = 42; // O compilador infere que o tipo � int
			var NumeroReal = 3.14; // O compilador infere que o tipo � double
			var Comprimentos = "ola! mundo!"; // O compilador infere que o tipo � string

			Console.WriteLine($"NumeroInteiros: {NumeroInteiro}, Type: {NumeroInteiro.GetType()}");
			Console.WriteLine($"NumerosReais: {NumeroReal}, Type: {NumeroReal.GetType()}");
			Console.WriteLine($"Comprimentos: {Comprimentos}, Type: {Comprimentos.GetType()}");

			// Exemplo 2: Infer�ncia com Tipos Complexos
			var Pessoa = new PessoaNova { Nome = "Alice", Idade = 30 }; // O compilador infere o tipo como Person

			Console.WriteLine($"Nome Pessoa: {Pessoa.Nome}, Idade: {Pessoa.Idade}");

			// Exemplo 3: Uso com Cole��es
			var numeros = new int[] { 1, 2, 3, 4, 5 }; // O compilador infere o tipo como int[]
			var nomes = new List<string> { "Alice", "Bob", "Charlie" }; // O compilador infere o tipo como List<string>

			Console.WriteLine("Numeros:");
			foreach (var numero in numeros)
			{
				Console.WriteLine(numero);
			}

			Console.WriteLine("Nomes:");
			foreach (var nome in nomes)
			{
				Console.WriteLine();
			}

			// Exemplo 4: N�o pode ser usado sem inicializa��o
			// var uninitializedVar; // Isto resultar� em um erro de compila��o, pois o tipo n�o pode ser inferido sem um valor inicial

			// Exemplo 5: Uso com LINQ
			var query = from n in numeros
						where n % 2 == 0
						select n;

			Console.WriteLine("Numeros Pares:");
			foreach (var NumeroPar in query)
			{
				Console.WriteLine(NumeroPar);
			}
		}
	}

	// Exemplo de classe usada no exemplo
	public class PessoaNova
	{
		public string Nome { get; set; }
		public int Idade { get; set; }
	}

}