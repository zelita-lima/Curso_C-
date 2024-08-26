using System;

namespace CursoCSharp{

    public class Escopo_Variavel
    {
        // Escopo Global: Variável acessível por todos os métodos desta classe.
        private int contadorGlobal = 0;

        public void Metodo1()
        {
            // Escopo Local: Variável local a este método, não acessível fora dele.
            int contadorLocal = 0;

            contadorLocal++; // Modificando a variável local
            contadorGlobal++; // Modificando a variável global

            Console.WriteLine($"Método 1 - Contador Local: {contadorLocal}");
            Console.WriteLine($"Método 1 - Contador Global: {contadorGlobal}");
        }

        public void Metodo2()
        {
            // Tentando acessar contadorLocal aqui causaria um erro, pois ela está fora do escopo.
            // contadorLocal++; // Isso não é permitido!

            contadorGlobal++; // Acessando a variável global
            Console.WriteLine($"Método 2 - Contador Global: {contadorGlobal}");
        }

        public void Metodo3()
        {
            // Outra variável local
            string mensagemLocal = "Esta é uma mensagem local.";

            // A variável global ainda pode ser acessada e modificada
            contadorGlobal++;

            Console.WriteLine($"Método 3 - Contador Global: {contadorGlobal}");
            Console.WriteLine($"Método 3 - Mensagem Local: {mensagemLocal}");
        }

        // Outro método para ilustrar o uso do escopo global
        public void ExibirContadorGlobal()
        {
            Console.WriteLine($"Contador Global Atual: {contadorGlobal}");
        }
    }
}