using System;

namespace Curso_C_
{
    class Program
    {
        static void Main()
        {
            // Questão 1: Calcular a soma de dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine($"A soma dos dois números é: {soma}");

            // Questão 2: Calcular a diferença entre dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            numero2 = int.Parse(Console.ReadLine());

            int diferenca = numero1 - numero2;
            Console.WriteLine($"A diferença entre {numero1} e {numero2} é: {diferenca}");

            // Questão 3: Calcular a multiplicação de dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            numero2 = int.Parse(Console.ReadLine());

            int produto = numero1 * numero2;
            Console.WriteLine($"A multiplicação dos números é: {produto}");

            // Questão 4: Calcular a divisão de dois números inteiros com tratamento para divisão por zero
            Console.Write("Digite o primeiro número inteiro: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero2 != 0)
            {
                double divisao = (double)numero1 / numero2;
                Console.WriteLine($"A divisão de {numero1} por {numero2} é: {divisao}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            // Questão 5: Calcular o resto da divisão de dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero2 != 0)
            {
                int resto = numero1 % numero2;
                Console.WriteLine($"O resto da divisão de {numero1} por {numero2} é: {resto}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            // Questão 6: Incrementar um número inteiro em 1
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            numero++;
            Console.WriteLine($"O número incrementado em 1 é: {numero}");

            // Questão 7: Decrementar um número inteiro em 1
            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());
            numero--;
            Console.WriteLine($"O número decrementado em 1 é: {numero}");

            // Questão 8: Calcular a média de dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            double media = (num1 + num2) / 2.0;
            Console.WriteLine($"A média dos números {num1} e {num2} é: {media}");

            // Questão 9: Soma dos dois primeiros números e subtração do terceiro
            Console.Write("Digite o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número inteiro: ");
            int n3 = int.Parse(Console.ReadLine());

            double resultado = (n1 + n2) - n3;
            Console.WriteLine($"A soma dos dois primeiros números é {n1 + n2} e subtraída pelo terceiro número ({n3}) resulta em {resultado}");

            // Questão 10: Calcular o quadrado do primeiro número somado ao segundo número
            Console.Write("Digite o primeiro número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            double quadradoSoma = (a * a) + b;
            Console.WriteLine($"O quadrado do primeiro número ({a}^2) somado ao segundo número é: {quadradoSoma}");

            // Questão 11: Dobro e metade de um valor
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            double dobro = valor * 2;
            double metade = valor / 2;
            Console.WriteLine($"O dobro do valor é: {dobro}");
            Console.WriteLine($"A metade do valor é: {metade}");

            // Questão 12: Calcular (a + b) * (a - b)
            Console.Write("Digite o primeiro número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            b = int.Parse(Console.ReadLine());

            double resultadoExpresso = (a + b) * (a - b);
            Console.WriteLine($"O resultado da expressão (a + b) * (a - b) é: {resultadoExpresso}");

            // Questão 13: Soma dos quadrados dos dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            b = int.Parse(Console.ReadLine());

            double somaQuadrados = (a * a) + (b * b);
            Console.WriteLine($"A soma do quadrado do primeiro número e do quadrado do segundo número é: {somaQuadrados}");

            // Questão 14: Calcular o número ao cubo
            Console.Write("Digite um número inteiro: ");
            int numeroCubo = int.Parse(Console.ReadLine());

            double cubo = Math.Pow(numeroCubo, 3);
            Console.WriteLine($"O número {numeroCubo} ao cubo é: {cubo}");

            // Questão 15: Calcular a expressão a * (b + a) / b
            Console.Write("Digite o primeiro número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            b = int.Parse(Console.ReadLine());

            if (b != 0)
            {
                double resultadoExpressao = a * (b + a) / b;
                Console.WriteLine($"O resultado da expressão a * (b + a) / b é: {resultadoExpressao}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            // Questão 16: Quadrado da diferença entre o número e 5
            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            double quadradoDiferenca = Math.Pow(numero - 5, 2);
            Console.WriteLine($"O quadrado da diferença entre o número e 5 é: {quadradoDiferenca}");

            // Questão 17: Média aritmética entre dois números
            Console.Write("Digite o primeiro número inteiro: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            num2 = int.Parse(Console.ReadLine());

            double mediaAritmetica = (num1 + num2) / 2.0;
            Console.WriteLine($"A média aritmética entre os números é: {mediaAritmetica}");

            // Questão 18: Conversão de reais para dólares
            Console.Write("Digite um valor em reais: ");
            double reais = double.Parse(Console.ReadLine());
            double taxaCambio = 5.0; // Taxa de câmbio fixa
            double dolares = reais / taxaCambio;
            Console.WriteLine($"O valor em dólares é: {dolares}");

            // Questão 19: Calcular a quantidade total de horas a partir dos dias
            Console.Write("Digite a quantidade de dias: ");
            int dias = int.Parse(Console.ReadLine());
            int horasTotal = dias * 24;
            Console.WriteLine($"A quantidade total de horas é: {horasTotal}");

            // Questão 20: Calcular o total em minutos a partir de horas e minutos
            Console.Write("Digite a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            int totalMinutos = (horas * 60) + minutos;
            Console.WriteLine($"O total em minutos é: {totalMinutos}");
        }
    }
}
