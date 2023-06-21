using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao8
    {
        public static void Executar()
        {
            // Solicita ao usuário a quantidade de veículos da locadora
            Console.WriteLine("Digite a quantidade de veículos da locadora:");
            int quantidadeVeiculos = int.Parse(Console.ReadLine());

            // Solicita ao usuário o valor do aluguel por veículo
            Console.WriteLine("Digite o valor do aluguel por veículo:");
            double valorAluguel = double.Parse(Console.ReadLine());

            // Calcula as informações solicitadas
            double faturamentoAnual = CalcularFaturamentoAnual(quantidadeVeiculos, valorAluguel);
            double valorMultasMes = CalcularValorMultasMes(quantidadeVeiculos, valorAluguel);
            double valorManutencaoAnual = CalcularValorManutencaoAnual(quantidadeVeiculos);

            // Exibe os resultados na tela
            Console.WriteLine($"Faturamento Anual: R$ {faturamentoAnual}");
            Console.WriteLine($"Valor das Multas no Mês: R$ {valorMultasMes}");
            Console.WriteLine($"Valor da Manutenção Anual: R$ {valorManutencaoAnual}");

            // Grava os resultados no arquivo "resultado.txt"
            GravarResultadosEmArquivo(faturamentoAnual, valorMultasMes, valorManutencaoAnual);
        }

        static double CalcularFaturamentoAnual(int quantidadeVeiculos, double valorAluguel)
        {
            int alugueisPorMes = quantidadeVeiculos / 3;
            double faturamentoMensal = alugueisPorMes * valorAluguel;
            double faturamentoAnual = faturamentoMensal * 12;
            return faturamentoAnual;
        }

        static double CalcularValorMultasMes(int quantidadeVeiculos, double valorAluguel)
        {
            int devolucoesAtrasadas = quantidadeVeiculos / 10;
            double valorMultasMes = devolucoesAtrasadas * valorAluguel * 0.2;
            return valorMultasMes;
        }

        static double CalcularValorManutencaoAnual(int quantidadeVeiculos)
        {
            int veiculosManutencao = (int)(quantidadeVeiculos * 0.02);
            double valorManutencaoAnual = veiculosManutencao * 600;
            return valorManutencaoAnual;
        }

        static void GravarResultadosEmArquivo(double faturamentoAnual, double valorMultasMes, double valorManutencaoAnual)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("resultado.txt"))
                {
                    sw.WriteLine($"Faturamento Anual: R$ {faturamentoAnual}");
                    sw.WriteLine($"Valor das Multas no Mês: R$ {valorMultasMes}");
                    sw.WriteLine($"Valor da Manutenção Anual: R$ {valorManutencaoAnual}");
                }

                Console.WriteLine("Resultados gravados com sucesso no arquivo 'resultado.txt'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os resultados no arquivo: " + ex.Message);
            }
        }
    }
}
