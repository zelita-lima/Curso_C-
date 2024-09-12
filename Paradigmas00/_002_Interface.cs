using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.Paradigmas00
{
    internal class _002_Interface
    {
        // Definição da interface
        public interface IAnimal
        {
            // Métodos da interface (não possuem implementação)
            void FazerSom();//eles nao retornam nada 
            void ExibirInformacoes();
        }

        // Classe Cachorro implementa a interface IAnimal
        public class CachorroInter : IAnimal
        {
            public string Nome { get; set; }

            public CachorroInter(string nome)
            {
                Nome = nome;
            }

            // Implementação dos métodos da interface
            public void FazerSom()
            {
                Console.WriteLine($"{Nome} late.");
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Este é um cachorro chamado {Nome}.");
            }
        }

        // Classe Gato implementa a interface IAnimal
        public class GatoInter : IAnimal
        {
            public string Nome { get; set; }

            public GatoInter(string nome)
            {
                Nome = nome;
            }

            // Implementação dos métodos da interface
            public void FazerSom()
            {
                Console.WriteLine($"{Nome} mia.");
            }

            public void ExibirInformacoes()//classe limão== filho 1 caipirosca ==filho 2 mousse de limão ==filho 3 miojo de limão
            {
                Console.WriteLine($"Este é um gato chamado {Nome}.");
            }
        }

        // Classe explicativa
        public class ExplicadorDeInterface
        {
            // Método para explicar o conceito de interface
            public void ExplicarInterface()
            {
                Console.WriteLine("Uma interface em C# define um contrato que as classes devem seguir OI||||||||||.");
                Console.WriteLine("Ela especifica métodos e propriedades, mas não fornece implementação.");
                Console.WriteLine("As classes que implementam uma interface devem fornecer a implementação dos métodos definidos.");
                Console.WriteLine("Isso permite que diferentes classes compartilhem um comportamento comum, sem necessidade de herança.");
                Console.WriteLine("No exemplo, tanto a classe 'Cachorro' quanto a classe 'Gato' implementam a interface 'IAnimal'.");
                Console.WriteLine("Ambas fornecem suas próprias versões dos métodos 'FazerSom' e 'ExibirInformacoes', seguindo o contrato da interface.");
                Console.WriteLine("Uma vantagem do uso de interfaces é a possibilidade de polimorfismo. Podemos tratar diferentes classes que implementam a mesma interface de maneira uniforme.");
            }
        }
    }
}
