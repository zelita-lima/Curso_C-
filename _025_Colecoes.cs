using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    internal class _025_colecoes
    {
        public class Colecoes
        {
            public void ExplicarDictionary()
            {
                Console.WriteLine("=== Dictionary ===");
                // O Dictionary armazena pares de chave-valor.
                Dictionary<int, string> dicionario = new Dictionary<int, string>();
                dicionario.Add(1, "Um");
                dicionario.Add(2, "Dois");
                dicionario.Add(3, "Três");

                // Acessando valores pelo índice
                Console.WriteLine($"Chave 1: {dicionario[1]}");
                Console.WriteLine($"Chave 2: {dicionario[2]}");

                // Verificando se uma chave existe
                if (dicionario.ContainsKey(3))
                {
                    Console.WriteLine("A chave 3 existe.");
                }

                // Iterando sobre o Dictionary
                foreach (var par in dicionario)
                {
                    Console.WriteLine($"Chave: {par.Key}, Valor: {par.Value}");
                }
            }

            public void ExplicarQueue()
            {
                Console.WriteLine("=== Queue ===");
                // Queue segue a regra FIFO (First In, First Out).
                Queue<string> fila = new Queue<string>();
                fila.Enqueue("Primeiro");//o primeiro a entrar e o primeiro a sair
                fila.Enqueue("Segundo");
                fila.Enqueue("Terceiro");

                // Removendo e acessando elementos na ordem em que foram adicionados
                Console.WriteLine($"Primeiro da fila: {fila.Dequeue()}");
                Console.WriteLine($"Segundo da fila: {fila.Dequeue()}");
                // Verificando o próximo item na fila sem removê-lo
                Console.WriteLine($"Próximo na fila: {fila.Peek()}");
            }

            public void ExplicarStack()
            {
                Console.WriteLine("=== Stack ===");
                // Stack segue a regra LIFO (Last In, First Out).
                Stack<string> pilha = new Stack<string>();
                pilha.Push("Primeiro");//o ultimo a entrar e o primeiro a sair 
                pilha.Push("Segundo");
                pilha.Push("Terceiro");

                // Removendo e acessando elementos na ordem inversa em que foram adicionados
                Console.WriteLine($"Topo da pilha: {pilha.Pop()}");
                Console.WriteLine($"Segundo na pilha: {pilha.Pop()}");

                // Verificando o próximo item na pilha sem removê-lo
                Console.WriteLine($"Próximo no topo: {pilha.Peek()}");
            }

            public void ExplicarSet()
            {
                Console.WriteLine("=== HashSet ===");
                // HashSet é uma coleção que não permite duplicatas.
                HashSet<int> conjunto = new HashSet<int>();
                conjunto.Add(1);
                conjunto.Add(2);
                conjunto.Add(2); // Tentativa de adicionar duplicata será ignorada
                conjunto.Add(3);

                // Iterando sobre o HashSet
                foreach (var item in conjunto)
                {
                    Console.WriteLine(item);
                }

                // Verificando a existência de um item
                if (conjunto.Contains(2))
                {
                    Console.WriteLine("O número 2 está no conjunto.");
                }
            }

        }
    }
}
