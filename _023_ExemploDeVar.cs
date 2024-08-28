using System;

namespace Curso_C_
{
    internal class _023_ExemploDeVar
    {
        //Exercícios Teóricos
        //1. Definição e Propósito:
        //o Pergunta: O que significa a palavra-chave var em C# e qual é o seu propósito?

        //Resposta: A palavra-chave var em C# é usada para declarar variáveis com tipo inferido pelo compilador. Em vez de especificar explicitamente o tipo da variável,
        //você usa var e o tipo é determinado com base na expressão de inicialização. O propósito de var é simplificar o código e torná-lo mais legível, especialmente quando
        //o tipo da variável é complexo ou longamente descrito.

        //2. Inferência de Tipo:
        //o Pergunta: Como o compilador determina o tipo de uma variável quando vocêusa var?

        //Resposta: O compilador determina o tipo da variável var com base na expressão de inicialização fornecida. Por exemplo, se você declarar var x = 10;, o compilador
        //infere que x é do tipo int porque 10 é um literal inteiro. A inferência ocorre no momento da compilação, e o tipo é fixo e não pode ser alterado depois que a
        //variável é inicializada.

        //3. Regras e Restrições:
        //o Pergunta: Quais são as restrições no uso da palavra-chave var em C#?

        /*1. Definição e Propósito da Palavra-chave var em C#
        Pergunta: O que significa a palavra-chave var em C# e qual é o seu propósito?

        Resposta: A palavra-chave var em C# é usada para declarar variáveis com tipo inferido pelo compilador. Em vez de especificar explicitamente o tipo da variável,
        você usa var e o tipo é determinado com base na expressão de inicialização. O propósito de var é simplificar o código e torná-lo mais legível, especialmente quando
        o tipo da variável é complexo ou longamente descrito.

        2. Inferência de Tipo
        Pergunta: Como o compilador determina o tipo de uma variável quando você usa var?

        esposta: O compilador determina o tipo da variável var com base na expressão de inicialização fornecida.Por exemplo, se você declarar var x = 10;, o compilador 
        infere que x é do tipo int porque 10 é um literal inteiro.A inferência ocorre no momento da compilação, e o tipo é fixo e não pode ser alterado depois que a variável
        é inicializada.

        3. Regras e Restrições
        Pergunta: Quais são as restrições no uso da palavra-chave var em C#?

        Resposta:
        A variável deve ser inicializada na mesma linha em que é declarada. O compilador não pode inferir o tipo sem um valor inicial.
        var não pode ser usado para variáveis sem inicialização ou para variáveis que precisam ser declaradas sem um valor inicial claro.
        var não pode ser usado para parâmetros de método ou retornos de método (exceto em expressões de inicialização).
        var não é apropriado quando o tipo não pode ser inferido claramente.*/

        //4. Diferença entre var e Tipos Explícitos:
        //o Pergunta: Qual é a diferença entre usar var e declarar uma variável com umtipo explícito?

        /*var: O tipo é inferido pelo compilador com base na expressão de inicialização.É mais conciso e pode melhorar a legibilidade em alguns casos, mas o tipo ainda é fortemente tipado e fixo após a inferência.
        var number = 42; // Tipo inferido como int

        Tipo Explícito: Você declara explicitamente o tipo da variável.Isso pode ser mais claro para quem está lendo o código, especialmente quando o tipo não é óbvio ou quando não há uma expressão de inicialização imediata.
        int number = 42; // Tipo explicitamente declarado como int*/

        //Declaração de Variáveis com var:
        // Exercício: Declare uma variável de cada um dos seguintes tipos usando var atribua a elas valores apropriados.Depois, exiba o tipo da variável usando
        //GetType() para confirmar a inferência do tipo.

        var integer = 10;
        var floatingPoint = 10.5;
        var text = "Hello, World!";
        var boolean = true;

        // Exibindo os tipos das variáveis
        Console.WriteLine(integer.GetType()); // Output: System.Int32
        Console.WriteLine(floatingPoint.GetType()); // Output: System.Double
        Console.WriteLine(text.GetType()); // Output: System.String
        Console.WriteLine(boolean.GetType()); // Output: System.Boolean

        //Utilizando var em Métodos de LINQ:
        // Exercício: Crie uma lista de inteiros e use um método LINQ para ordenar a lista
        //em ordem crescente.Declare a variável que armazena o resultado usando var.
        
        class Program
        {
            static void Main()
            {
                var numbers = new List<int> { 5, 2, 9, 1, 5, 6 };
                var sortedNumbers = numbers.OrderBy(n => n);

                foreach (var number in sortedNumbers)
                {
                    Console.WriteLine(number); // Exibe os números em ordem crescente
                }
            }
        }

        //Declaração de Variáveis com Tipos Complexos:
        // Exercício: Declare uma variável var para um tipo complexo, como um
        //Dictionary ou uma instância de uma classe personalizada.Mostre como a
        //inferência de tipo funciona com tipos mais complexos.

        var dictionary = new Dictionary<string, int>
        {
            { "apple", 1 },
            { "banana", 2 },
            { "cherry", 3 }
        };

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

            // Definindo uma classe personalizada
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
            }

            var person = new Person { Name = "Alice", Age = 30 };
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        //Refatoração de Código:
        // Exercício: Refatore o seguinte código para usar var em vez de tipos explícitosonde possível.

        Dictionary<string, List<int>> myDict = new Dictionary<string, List<int>>();
        List<int> myList = new List<int> { 1, 2, 3 };
        myDict.Add("numbers", myList);
        Refatorado usando var:

        csharp
        Copiar código
        var myDict = new Dictionary<string, List<int>>();
        var myList = new List<int> { 1, 2, 3 };
        myDict.Add("numbers", myList);

        //Trabalhando com Tipos Anônimos:
        // Exercício: Crie um tipo anônimo usando var para armazenar informações de
        //uma pessoa (nome e idade) e exiba essas informações.

        var person = new { Name = "John", Age = 25 };
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
