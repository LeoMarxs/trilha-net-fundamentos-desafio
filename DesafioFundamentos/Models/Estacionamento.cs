using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            System.Console.WriteLine("------------------------------------------");
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            System.Console.WriteLine("------------------------------------------");
            string placa = Console.ReadLine();
           
            veiculos.Add(placa);
            System.Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Veículo com placa {placa} adicionado ao estacionamento.");
            System.Console.WriteLine("----------------------------------------------------");
        }

        public void RemoverVeiculo()
        {
            System.Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.WriteLine("-------------------------------------------");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                System.Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                System.Console.WriteLine("------------------------------------------------------------------");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                System.Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                System.Console.WriteLine("-------------------------------------------------------------------");
            }
            else
            {
                System.Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                System.Console.WriteLine("---------------------------------");
                Console.WriteLine("Os veículos estacionados são:");
                System.Console.WriteLine("---------------------------------");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                    System.Console.WriteLine("---------------------------------");
                }
            }
            else
            {
                System.Console.WriteLine("-----------------------------");
                Console.WriteLine("Não há veículos estacionados.");
                System.Console.WriteLine("-----------------------------");
            }
        }
    }
}
