using System;

namespace CursoCSharp
{
    // Definição de uma classe chamada Pessoa
    public class Pessoa//abstração de uma pessoa  ele nao retorna
    {
        // Atributos (variáveis de instância)
        public string Nome;//carateristicas  obrigatorio a reposta
        public int Idade;

        // Membro Estático (variável de classe)
        public static int NumeroDePessoas;

        // Construtor (um método especial para criar objetos)
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            NumeroDePessoas++;
        }

        // Método para exibir informações da pessoa
        public void ExibirInformacoes()//nao retorna nada se e void
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

        // Método Estático (pertence à classe, não à instância)
        public static void ExibirNumeroDePessoas()//o on=bjeto nao chega
        {
            Console.WriteLine($"Número de pessoas criadas: {NumeroDePessoas}");
        }
    }
}
