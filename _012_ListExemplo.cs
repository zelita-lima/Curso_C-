using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    public class ListaExemplo
    {
        public static void DemonstrarLista()
        {
            // 1. Criação e Inicialização de uma Lista
            //evolução do vetor List ao inves do array
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 1, 2 };
            List<string> frutas = new List<string>();

            // 2. Adicionar Elementos à Lista
            frutas.Add("Maçã");
            frutas.Add("Banana");
            frutas.Add("Laranja");
            frutas.Add("kiwi");
            frutas.Add("Tamara");

            // 3. Acessar Elementos na Lista
            Console.WriteLine("Primeiro elemento da lista 'numeros': " + numeros[0]);
            Console.WriteLine("Segundo elemento da lista 'frutas': " + frutas[1]);

            // 4. Inserir Elementos em uma Posição Específica
            frutas.Insert(1, "Manga");
            Console.WriteLine("\nLista de frutas após inserção:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // 5. Remover Elementos da Lista
            frutas.Remove("Banana"); // Remove o primeiro "Banana"
            frutas.RemoveAt(0); // Remove o primeiro elemento
            Console.WriteLine("\nLista de frutas após remoções:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // 6. Verificar a Existência de um Elemento na Lista
            bool contemMaca = frutas.Contains("Maçã");
            Console.WriteLine("\nA lista contém 'Maçã'? " + contemMaca);

            // 7. Obter o Índice de um Elemento
            int indiceLaranja = frutas.IndexOf("Laranja");
            Console.WriteLine("O índice de 'Laranja' é: " + indiceLaranja);

            // 8. Contagem de Elementos na Lista
            Console.WriteLine("Número de elementos na lista 'numeros': " + numeros.Count);

            // 9. Iteração em uma Lista
            Console.WriteLine("\nIteração usando 'foreach' na lista 'numeros':");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // 10. Converter uma Lista para Array
            int[] arrayDeNumeros = numeros.ToArray();
            Console.WriteLine("\nArray convertido da lista 'numeros':");
            foreach (int numero in arrayDeNumeros)
            {
                Console.WriteLine(numero);
            }

            // 11. Limpar a Lista
            frutas.Clear();
            Console.WriteLine("\nNúmero de elementos na lista 'frutas' após Clear(): " + frutas.Count);
        }
    }
}
