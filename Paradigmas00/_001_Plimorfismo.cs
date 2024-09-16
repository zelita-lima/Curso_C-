using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Curso_C_.Paradigmas00._002_Interface;

namespace Curso_C_.Paradigmas00
{
    internal class _001_Plimorfismo
    {
        // Classe base Animal
        public class AnimalPoli
        {
            public string Nome { get; set; }

            // Construtor da classe base
            public AnimalPoli(string nome)
            {
                Nome = nome;
            }

            // Método virtual para polimorfismo
            public virtual void FazerSom()//metodo generico so diz oq tem que fazer
            {
                Console.WriteLine($"{Nome} faz um som genérico.");
            }
        }

        // Classe derivada Cachorro que herda de Animal
        public class CachorroPoli : AnimalPoli
        {
            public CachorroPoli(string nome) : base(nome)
            {
            }

            // Sobrescrevendo o método FazerSom para polimorfismo
            public override void FazerSom()//sobreescrita
            {
                Console.WriteLine($"{Nome} late.");
            }
        }

        // Classe derivada Gato que herda de Animal
        public class GatoPoli : AnimalPoli
        {
            public GatoPoli(string nome) : base(nome)
            {
            }

            // Sobrescrevendo o método FazerSom para polimorfismo
            public override void FazerSom()
            {
                Console.WriteLine($"{Nome} mia.");
            }
        }

        // Classe ExplicadoraDePolimorfismo
        public class ExplicadoraDePolimorfismo
        {
            // Método para explicar o conceito de polimorfismo
            public void ExplicarPolimorfismo()
            {
                Console.WriteLine("Polimorfismo é um dos pilares da Programação Orientada a Objetos.");
                Console.WriteLine("Ele permite que diferentes classes derivadas de uma classe base tenham comportamentos distintos, embora sejam tratadas como instâncias da classe base.");
                Console.WriteLine("Em outras palavras, o polimorfismo permite que uma mesma operação (como chamar um método) tenha diferentes comportamentos dependendo do tipo de objeto com o qual estamos lidando.");
                Console.WriteLine("No exemplo a seguir, as classes 'Cachorro' e 'Gato' derivam da classe base 'Animal' e sobrescrevem o método 'FazerSom'.");
                Console.WriteLine("Mesmo que tratemos os objetos como 'Animal', cada um executa sua própria versão do método 'FazerSom'.");
            }
            /*
            // Método para demonstrar polimorfismo em ação
            public void DemonstrarPolimorfismo()
            {
                // Criando um array de animais
                Animal[] animais = new Animal[3];
                animais[0] = new Cachorro("Rex");
                animais[1] = new Gato("Mimi");
                animais[2] = new Animal("Animal Genérico");

                // Chamando o método FazerSom para cada animal
                foreach (Animal animal in animais)
                {
                    animal.FazerSom(); // Polimorfismo em ação
                }
            */
            }
        }
    }

