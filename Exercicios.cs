using System;

public class ExerciciosPF
{
    public static void Main(string[] args)
    {
        // Primeiro, executa o programa de verificação de número par ou ímpar
        Console.WriteLine("Escreva um número de 1 a 9:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número que você escreveu é um número par.");
        }
        else
        {
            Console.WriteLine("O número que você escreveu é um número ímpar.");
        }

        // Depois, converte o valor de reais para dólares
        //Console.Write("Valor em Reais? ");
        //double reais = Convert.ToDouble(Console.ReadLine());

        //double dolars = reais / 5.38;

        //Console.WriteLine("$ = " + dolars);
    }
}
using System;
using System.Collections.Generic;
//Arrays
//Criando e Inicializando um Array
//Crie um array de inteiros chamado numeros com capacidade para 5 elementos. Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.
public class Exercicios
{
    public static void DemonstrarExercicios()
    {
        int[] valores = {2, 4, 6, 8, 10};
       
        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine(valores[i]);
        }
    }
}


//Acessando Elementos de um Array
//Dado o array int[] valores = {1, 3, 5, 7, 9};, imprima o terceiro elemento do array.
public class Exercicios2
{
    public static void DemonstrarExercicios2()
    {
        int[] valores2 = {1, 3, 5, 7, 9};
       
        Console.WriteLine($"O terceiro elemento é: {valores2[2]}");
    }
} 

//Alterando Valores em um Array
//Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array.
public class Exercicios3
{
    public static void DemonstrarExercicios3()
    {
        string[] NomePessoas = {"Ana", "Bruno", "Carla"};
        
        NomePessoas[1] = "Beto";
        
        foreach (string nome in NomePessoas)
        {
            Console.WriteLine(nome);
        }
    }
}

//Calculando a Soma dos Elementos de um Array
//Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. Calcule e imprima a soma de todos os elementos do array.
public class Exercicios4
{
    public static void DemonstrarExercicios4()
    {
        int[] Notas = {7, 8, 9, 10, 6};
        
        int soma = 0;
        foreach (int nota in Notas)
        {
            soma += nota;
        }
        Console.WriteLine($"A soma das notas é: {soma}");
    }
}

//Procurando um Elemento em um Array
//Dado o array int[] numeros = {5, 10, 15, 20, 25};, escreva um código que verifique se o número 15 está presente no array e imprima uma mensagem confirmando.
public class Exercicios5
{
    public static void DemonstrarExercicios5()
    {
        int[] numeros = {5, 10, 15, 20, 25};
        bool encontrado = false;
        
        foreach (int numero in numeros)
        {
            if (numero == 15)
            {
                encontrado = true;
                break;
            }
        }
        Console.WriteLine(encontrado ? "O número 15 está presente no array." : "O número 15 não está presente no array.");
    }
}



//List
//Criando e Adicionando Elementos em uma List
//Crie uma List<string> chamada frutas. Adicione as frutas "Maçã", "Banana", "Laranja" e imprima todos os elementos da lista.
public class ListaExemplo
{
    public static void DemonstrarLista()
    {
        List<string> frutas = new List<string>();

        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Laranja");

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}

    
//Removendo um Elemento de uma List
//Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5. Remova o número 3 da lista e depois imprima os elementos restantes.
public class ListaExemplo2
{
    public static void DemonstrarLista2()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        numeros.Remove(3); // Remove o número 3
        Console.WriteLine("Lista de números após remoção do 3:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}    

//Acessando um Elemento Específico em uma List
//Dada a List<string> chamada cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"}, imprima a segunda cidade da lista.
 public class ListaExemplo3
{
   public static void DemonstrarLista3()
    {
      List<string> cidades = new List<string> {"São paulo", "Rio de Janeiro", "Belo horizonte"};

      Console.WriteLine("segunda cidade de lista de 'cidades';"+ cidades[1]);
    } 
}

   

//Contando Elementos em uma List
//Crie uma List<string> chamada animais e adicione os valores "Cachorro", "Gato", "Coelho". Escreva um código que imprima quantos elementos existem na lista.
 
public class ListaExemplo4
{
    public static void DemonstrarLista4()
    {
        List<string> animais = new List<string> { "Cachorro", "Gato", "Coelho" };

        Console.WriteLine("Número de elementos na lista 'animais': " + animais.Count);

        animais.Insert(1, "Periquito");
        Console.WriteLine("\nLista de Animais após inserção:");
        foreach (string animal in animais)
        {
            Console.WriteLine(animal);
        }
    }
}

//Escopo de Variáveis

//Variável Local em um Método
//Escreva um método chamado CalculaSoma que declare uma variável local int soma e calcule a soma de dois números passados como parâmetros. A variável soma deve estar acessível apenas dentro deste método.
 public class Escopo_Variavel
{
    public void Metodo1()
    {
        int calculoSoma = 2 + 3;
        calculoSoma++; // Modificando a variável local
        Console.WriteLine($"Método 1 - Contador Local: {calculoSoma}");
    }
}
//Variável Global em uma Classe
//Crie uma classe chamada Carro com uma variável global string marca. No método Main, instancie um objeto Carro, defina a marca do carro como "Toyota" e imprima a marca.
public class Escopo_Variavel2
{
    string? marca = "ford"; // Variável global da classe
    
    public void Metodo1()
    {
        string? marcaLocal = "honda"; // Definindo uma variável local no método
        // Usando a variável local no método
        Console.WriteLine($"Marca local: {marcaLocal}");
        // Usando a variável global da classe
        Console.WriteLine($"Marca global: {marca}");
    }
}
//Conflito de Escopo
//Escreva um método onde você declare uma variável local com o mesmo nome de uma variável global da classe. Mostre como acessar ambas as variáveis no mesmo método.
 public class Escopo_Variavel3
{
    private int nomr = 0; // Variável global da classe

    public void Metodo2()
    {
        int nomrLocal = 0; // Variável local
        nomrLocal++; // Modificando a variável local
        nomr++; // Modificando a variável global

        Console.WriteLine($"Método 1 - Contador Local: {nomrLocal}");
        Console.WriteLine($"Método 1 - Contador Global: {nomr}");
    }
}
//Variável Local dentro de um Bloco Condicional
//Escreva um código onde uma variável int x seja declarada dentro de um bloco if. Tente acessar essa variável fora do bloco if e observe o que acontece.
public class EscopoVariavel
{
    public void TestarEscopo()
    {
        if (true)
        {
            int x = 10; // Variável local declarada dentro do bloco if
            Console.WriteLine($"Dentro do if: {x}"); // Acessível aqui
        }

    }
}
//Alterando o Valor de uma Variável Global
//Crie uma variável global int contador em uma classe. No método Main, altere o valor de contador dentro de um loop for e depois imprima o valor final de contador.
 public class Escopo_Variavel4
{
     private int contador = 0;

     public void metodo9()
     {
        for (int i = 0 ; i < 10 ; i++)
        {
            contador++;
        }
        Console.WriteLine($"metodo 2 - contador global final;{contador}");
     }
}
//Capturando uma Exceção de Conversão de Tipo
//Tente converter uma string não numérica para um inteiro usando int.Parse. Use try-catch para capturar a exceção e imprima uma mensagem apropriada.
public class Escopo_Variavel5
{
    public void Metodo3()
    {
        string mensagemLocal = "Esta é uma mensagem local.";

        try
        {
            int numero = int.Parse("não numérico"); // Isso causará uma exceção
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: A string fornecida não é um número válido.");
        }

        Console.WriteLine($"Método 3 - Mensagem Local: {mensagemLocal}");
    }
}
//Lançando Exceções
//Escreva um método que recebe um número inteiro. Se o número for negativo, lance uma ArgumentException. Capture a exceção no método Main e imprima uma mensagem apropriada.
public class ExcecaoExemplo
{
    // Método que lança uma ArgumentException se o número for negativo
    public void VerificarNumero(int numero)
    {
        if (numero < 0)
        {
            throw new Exception("O número não pode ser negativo.");
        }

        Console.WriteLine("Número aceito: " + numero);
    }
}

using System;

public class ExerciciosPF
{
    public static void Main(string[] args)
    {
        // Primeiro, executa o programa de verificação de número par ou ímpar
        Console.WriteLine("Escreva um número de 1 a 9:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número que você escreveu é um número par.");
        }
        else
        {
            Console.WriteLine("O número que você escreveu é um número ímpar.");
        }

        // Depois, converte o valor de reais para dólares
        //Console.Write("Valor em Reais? ");
        //double reais = Convert.ToDouble(Console.ReadLine());

        //double dolars = reais / 5.38;

        //Console.WriteLine("$ = " + dolars);
    }
}


using System;
using System.Collections.Generic;
//Arrays
//Criando e Inicializando um Array
//Crie um array de inteiros chamado numeros com capacidade para 5 elementos. Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.
public class Exercicios
{
    public static void DemonstrarExercicios()
    {
        int[] valores = {2, 4, 6, 8, 10};
       
        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine(valores[i]);
        }
    }
}


//Acessando Elementos de um Array
//Dado o array int[] valores = {1, 3, 5, 7, 9};, imprima o terceiro elemento do array.
public class Exercicios2
{
    public static void DemonstrarExercicios2()
    {
        int[] valores2 = {1, 3, 5, 7, 9};
       
        Console.WriteLine($"O terceiro elemento é: {valores2[2]}");
    }
} 

//Alterando Valores em um Array
//Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array.
public class Exercicios3
{
    public static void DemonstrarExercicios3()
    {
        string[] NomePessoas = {"Ana", "Bruno", "Carla"};
        
        NomePessoas[1] = "Beto";
        
        foreach (string nome in NomePessoas)
        {
            Console.WriteLine(nome);
        }
    }
}

//Calculando a Soma dos Elementos de um Array
//Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. Calcule e imprima a soma de todos os elementos do array.
public class Exercicios4
{
    public static void DemonstrarExercicios4()
    {
        int[] Notas = {7, 8, 9, 10, 6};
        
        int soma = 0;
        foreach (int nota in Notas)
        {
            soma += nota;
        }
        Console.WriteLine($"A soma das notas é: {soma}");
    }
}

//Procurando um Elemento em um Array
//Dado o array int[] numeros = {5, 10, 15, 20, 25};, escreva um código que verifique se o número 15 está presente no array e imprima uma mensagem confirmando.
public class Exercicios5
{
    public static void DemonstrarExercicios5()
    {
        int[] numeros = {5, 10, 15, 20, 25};
        bool encontrado = false;
        
        foreach (int numero in numeros)
        {
            if (numero == 15)
            {
                encontrado = true;
                break;
            }
        }
        Console.WriteLine(encontrado ? "O número 15 está presente no array." : "O número 15 não está presente no array.");
    }
}



//List
//Criando e Adicionando Elementos em uma List
//Crie uma List<string> chamada frutas. Adicione as frutas "Maçã", "Banana", "Laranja" e imprima todos os elementos da lista.
public class ListaExemplo
{
    public static void DemonstrarLista()
    {
        List<string> frutas = new List<string>();

        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Laranja");

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}

    
//Removendo um Elemento de uma List
//Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5. Remova o número 3 da lista e depois imprima os elementos restantes.
public class ListaExemplo2
{
    public static void DemonstrarLista2()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        numeros.Remove(3); // Remove o número 3
        Console.WriteLine("Lista de números após remoção do 3:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}    

//Acessando um Elemento Específico em uma List
//Dada a List<string> chamada cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"}, imprima a segunda cidade da lista.
 public class ListaExemplo3
{
   public static void DemonstrarLista3()
    {
      List<string> cidades = new List<string> {"São paulo", "Rio de Janeiro", "Belo horizonte"};

      Console.WriteLine("segunda cidade de lista de 'cidades';"+ cidades[1]);
    } 
}

   

//Contando Elementos em uma List
//Crie uma List<string> chamada animais e adicione os valores "Cachorro", "Gato", "Coelho". Escreva um código que imprima quantos elementos existem na lista.
 
public class ListaExemplo4
{
    public static void DemonstrarLista4()
    {
        List<string> animais = new List<string> { "Cachorro", "Gato", "Coelho" };

        Console.WriteLine("Número de elementos na lista 'animais': " + animais.Count);

        animais.Insert(1, "Periquito");
        Console.WriteLine("\nLista de Animais após inserção:");
        foreach (string animal in animais)
        {
            Console.WriteLine(animal);
        }
    }
}

//Escopo de Variáveis

//Variável Local em um Método
//Escreva um método chamado CalculaSoma que declare uma variável local int soma e calcule a soma de dois números passados como parâmetros. A variável soma deve estar acessível apenas dentro deste método.
 public class Escopo_Variavel
{
    public void Metodo1()
    {
        int calculoSoma = 2 + 3;
        calculoSoma++; // Modificando a variável local
        Console.WriteLine($"Método 1 - Contador Local: {calculoSoma}");
    }
}
//Variável Global em uma Classe
//Crie uma classe chamada Carro com uma variável global string marca. No método Main, instancie um objeto Carro, defina a marca do carro como "Toyota" e imprima a marca.
public class Escopo_Variavel2
{
    string? marca = "ford"; // Variável global da classe
    
    public void Metodo1()
    {
        string? marcaLocal = "honda"; // Definindo uma variável local no método
        // Usando a variável local no método
        Console.WriteLine($"Marca local: {marcaLocal}");
        // Usando a variável global da classe
        Console.WriteLine($"Marca global: {marca}");
    }
}
//Conflito de Escopo
//Escreva um método onde você declare uma variável local com o mesmo nome de uma variável global da classe. Mostre como acessar ambas as variáveis no mesmo método.
 public class Escopo_Variavel3
{
    private int nomr = 0; // Variável global da classe

    public void Metodo2()
    {
        int nomrLocal = 0; // Variável local
        nomrLocal++; // Modificando a variável local
        nomr++; // Modificando a variável global

        Console.WriteLine($"Método 1 - Contador Local: {nomrLocal}");
        Console.WriteLine($"Método 1 - Contador Global: {nomr}");
    }
}
//Variável Local dentro de um Bloco Condicional
//Escreva um código onde uma variável int x seja declarada dentro de um bloco if. Tente acessar essa variável fora do bloco if e observe o que acontece.
public class EscopoVariavel
{
    public void TestarEscopo()
    {
        if (true)
        {
            int x = 10; // Variável local declarada dentro do bloco if
            Console.WriteLine($"Dentro do if: {x}"); // Acessível aqui
        }

    }
}
//Alterando o Valor de uma Variável Global
//Crie uma variável global int contador em uma classe. No método Main, altere o valor de contador dentro de um loop for e depois imprima o valor final de contador.
 public class Escopo_Variavel4
{
     private int contador = 0;

     public void metodo9()
     {
        for (int i = 0 ; i < 10 ; i++)
        {
            contador++;
        }
        Console.WriteLine($"metodo 2 - contador global final;{contador}");
     }
}
//Capturando uma Exceção de Conversão de Tipo
//Tente converter uma string não numérica para um inteiro usando int.Parse. Use try-catch para capturar a exceção e imprima uma mensagem apropriada.
public class Escopo_Variavel5
{
    public void Metodo3()
    {
        string mensagemLocal = "Esta é uma mensagem local.";

        try
        {
            int numero = int.Parse("não numérico"); // Isso causará uma exceção
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: A string fornecida não é um número válido.");
        }

        Console.WriteLine($"Método 3 - Mensagem Local: {mensagemLocal}");
    }
}
//Lançando Exceções
//Escreva um método que recebe um número inteiro. Se o número for negativo, lance uma ArgumentException. Capture a exceção no método Main e imprima uma mensagem apropriada.
public class ExcecaoExemplo
{
    // Método que lança uma ArgumentException se o número for negativo
    public void VerificarNumero(int numero)
    {
        if (numero < 0)
        {
            throw new Exception("O número não pode ser negativo.");
        }

        Console.WriteLine("Número aceito: " + numero);
    }
}

