using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.Paradigmas00
{
    internal class _003_ClasseAbstrata
    {
        // Classe abstrata Animal
        public abstract class AnimalAbs
        {
            public string Nome { get; set; }

            // Construtor da classe abstrata
            public AnimalAbs(string nome)
            {
                Nome = nome;
            }

            // Método abstrato (não possui implementação na classe base)
            public abstract void FazerSom();

            // Método concreto (com implementação na classe abstrata)
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Este é um {GetType().Name} chamado {Nome}.");
            }

            // Método para explicar o conceito de Classe Abstrata
            public void ExplicarClasseAbstrata()
            {
                Console.WriteLine("Uma classe abstrata é uma classe que não pode ser instanciada diretamente Oi!.");
                Console.WriteLine("Ela pode conter métodos abstratos (sem implementação) que devem ser implementados pelas classes derivadas.");
                Console.WriteLine("Também pode conter métodos concretos, com implementação compartilhada entre as subclasses.");
                Console.WriteLine("No exemplo, a classe 'Animal' é abstrata e contém o método abstrato 'FazerSom'. Cada subclasse (como 'Cachorro' e 'Gato') é obrigada a fornecer sua própria implementação para este método.");
                Console.WriteLine("Isso permite definir um comportamento comum para todas as subclasses, enquanto permite que cada subclasse tenha um comportamento específico para certos métodos.");
            }
        }

        // Classe derivada Cachorro
        public class CachorroAbs : AnimalAbs//dois ponto que dizer q ela tenha acesso a outra
        {
            public CachorroAbs(string nome) : base(nome)
            {
            }

            // Implementação do método abstrato
            public override void FazerSom()
            {
                Console.WriteLine($"{Nome} late.");
            }
        }

        // Classe derivada Gato
        public class GatoAbs : AnimalAbs
        {
            public GatoAbs(string nome) : base(nome)
            {
            }

            // Implementação do método abstrato
            public override void FazerSom()
            {
                Console.WriteLine($"{Nome} mia.");
            }
        }
    }
}
