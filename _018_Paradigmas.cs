using System;

namespace CursoCSharp
{
    // Classe que explica os conceitos básicos de Orientação a Objetos
    public class Paradigma
    {
        // Método que explica o que é Orientação a Objetos
        public void ExplicarOrientacaoAObjetos()
        {
            Console.WriteLine("Orientação a Objetos é um paradigma de programação baseado em objetos, que são instâncias de classes.");
            Console.WriteLine("Ele organiza o software como uma coleção de objetos que interagem entre si.");
            Console.WriteLine();
        }

        // Método que explica a diferença entre Programação Estruturada e Orientada a Objetos
        public void DiferencaEntreParadigmas()
        {
            Console.WriteLine("Programação Estruturada foca em funções e procedimentos, enquanto a Orientada a Objetos foca em objetos.");
            Console.WriteLine("Na Programação Estruturada, os dados e as funções que os manipulam são separados.");
            Console.WriteLine("Na Orientação a Objetos, os dados e os métodos que os manipulam são agrupados em objetos.");
            Console.WriteLine();
        }

        // Método que explica os Pilares da Orientação a Objetos
        public void ExplicarPilares()
        {
            // Explicando o Encapsulamento
            Console.WriteLine("Encapsulamento:");
            Console.WriteLine("Encapsulamento é o conceito de esconder os detalhes internos de um objeto e expor apenas o que é necessário.");
            Console.WriteLine("Isso é feito através de modificadores de acesso como public, private, protected.");
            Console.WriteLine();

            // Explicando a Abstração
            Console.WriteLine("Abstração:");
            Console.WriteLine("Abstração é o processo de expor apenas as funcionalidades essenciais de um objeto.");
            Console.WriteLine("É como criar uma interface simples para um sistema complexo.");
            Console.WriteLine();

            // Explicando a Herança
            Console.WriteLine("Herança:");
            Console.WriteLine("Herança permite que uma classe (subclasse) herde propriedades e métodos de outra classe (superclasse).");
            Console.WriteLine("Isso promove a reutilização de código e a criação de hierarquias.");
            Console.WriteLine();

            // Explicando o Polimorfismo
            Console.WriteLine("Polimorfismo:");
            Console.WriteLine("Polimorfismo permite que métodos com o mesmo nome se comportem de forma diferente, dependendo do contexto.");
            Console.WriteLine("Isso pode ser alcançado através de sobrecarga de métodos e sobrescrita de métodos.");
            Console.WriteLine();
        }

        // Método principal para executar as explicações
        public static void Main(string[] args)
        {
            Paradigma conceitos = new Paradigma();

            // Explicar Orientação a Objetos
            conceitos.ExplicarOrientacaoAObjetos();

            // Explicar a diferença entre Programação Estruturada e Orientada a Objetos
            conceitos.DiferencaEntreParadigmas();

            // Explicar os Pilares da Orientação a Objetos
            conceitos.ExplicarPilares();
        }
    }
}
