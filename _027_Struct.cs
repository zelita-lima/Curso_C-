using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    internal class _027_Struct
    {
        
      public struct Ponto
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Construtor da struct
        public Ponto(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Método para exibir os detalhes do ponto
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Ponto: ({X}, {Y})");
        }

        // Método para calcular a distância até outro ponto
        public double CalcularDistancia(Ponto outroPonto)
        {
            int dx = X - outroPonto.X;
            int dy = Y - outroPonto.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
    /* Tipo de Valor vs. Tipo de Referência:

class: É um tipo de referência. Quando você cria uma instância de uma classe, você está criando um objeto que é armazenado no heap. Variáveis de classe armazenam referências ao objeto, não o próprio objeto.
struct: É um tipo de valor. Quando você cria uma instância de uma struct, ela é armazenada na stack (ou no heap, se for um campo de uma classe) e as variáveis de struct contêm diretamente o valor.
Herança:

class: Suporta herança. Você pode criar uma classe base e derivar outras classes dela.
struct: Não suporta herança. Estruturas não podem ser base para outras structs ou classes e não podem derivar de outras structs ou classes (exceto para System.ValueType).
Construtores e Destrutores:

class: Pode ter construtores personalizados e destrutores (finalizadores).
struct: Tem um construtor padrão implícito (que inicializa todos os campos com valores padrão) e você pode definir construtores parametrizados, mas não pode ter um destruidor.
Inicialização e Cópia:

class: Quando você copia uma variável de classe, você copia a referência, não o objeto em si. Portanto, alterações em uma instância afetam todas as variáveis que referenciam essa instância.
struct: Quando você copia uma variável de struct, você copia o valor inteiro. Isso significa que alterações em uma cópia não afetam a instância original.
Nullabilidade:

class: Pode ser null. Você pode ter uma referência de classe que não aponta para nenhum objeto.
struct: Não pode ser null (exceto quando usado como Nullable<T>). Eles sempre contêm um valor.
Performance e Tamanho:

class: Usualmente usado quando você precisa de objetos maiores e mais complexos, especialmente quando a herança e polimorfismo são necessários.
struct: Usado para objetos pequenos e imutáveis que são frequentemente criados e destruídos, como vetores e coordenadas. Estruturas podem ter desempenho melhor para esses casos, mas usar structs grandes pode levar a uma maior sobrecarga de cópias.
Padronização:

class: Tipicamente usado para modelar entidades que possuem comportamento e estado mais complexo.
struct: Geralmente usado para dados simples e pequenas quantidades de informações que não precisam de herança ou polimorfismo.
    */
}
