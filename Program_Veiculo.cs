using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    // Classe Veiculo
    public class Veiculo
    {
        // Atributos privados
        private string marca;
        private string modelo;
        private int ano;
        private int quilometragem;

        // Propriedades públicas com encapsulamento
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Quilometragem
        {
            get { return quilometragem; }
            set { quilometragem = value; }
        }

        // Construtor
        public Veiculo(string marca, string modelo, int ano, int quilometragem)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.quilometragem = quilometragem;
        }

        // Método para exibir detalhes do veículo
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Quilometragem: {Quilometragem}");
        }

        // Método para realizar manutenção
        public void RealizarManutencao(int novaQuilometragem)
        {
            if (novaQuilometragem > quilometragem)
            {
                quilometragem = novaQuilometragem;
                Console.WriteLine("Manutenção realizada com sucesso!");
            }
        }
    }

    // Classe Garagem
    public class Garagem
    {
        // Lista privada de veículos
        private List<Veiculo> veiculosDisponiveis = new List<Veiculo>();

        // Método para adicionar veículo
        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculosDisponiveis.Add(veiculo);
        }

        // Método para remover veículo
        public void RemoverVeiculo(Veiculo veiculo)
        {
            veiculosDisponiveis.Remove(veiculo);
        }

        // Método para buscar veículo por modelo
        public Veiculo BuscarVeiculoPorModelo(string modelo)
        {
            return veiculosDisponiveis.Find(veiculo => veiculo.Modelo == modelo);
        }

        public List<Veiculo> ListarTodosVeiculos()
        {
            return veiculosDisponiveis; // Retorna a lista de veículos disponíveis
        }

        // Método para vender veículo
        public void VenderVeiculo(Veiculo veiculo)
        {
            if (veiculosDisponiveis.Contains(veiculo))
            {
                veiculosDisponiveis.Remove(veiculo);
                Console.WriteLine($"Veículo {veiculo.Modelo} vendido!");
            }
        }
    }

    // Classe Cliente
    public class Cliente
    {
        // Atributos privados
        private string nome;
        private string cpf;
        private List<Veiculo> veiculosComprados = new List<Veiculo>();

        // Construtor
        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        // Método para comprar veículo
        public void ComprarVeiculo(Veiculo veiculo, Garagem garagem)
        {
            Veiculo veiculoDisponivel = garagem.BuscarVeiculoPorModelo(veiculo.Modelo);
            if (veiculoDisponivel != null)
            {
                veiculosComprados.Add(veiculoDisponivel);
                garagem.RemoverVeiculo(veiculoDisponivel);
                Console.WriteLine($"{nome} comprou o veículo {veiculo.Modelo}.");
            }
        }

        // Método para exibir veículos comprados
        public void ExibirVeiculosComprados()
        {
            Console.WriteLine($"Veículos comprados por {nome}:");
            foreach (var veiculo in veiculosComprados)
            {
                veiculo.ExibirDetalhes();
            }
        }
    }
}
