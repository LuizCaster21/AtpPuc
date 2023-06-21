using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao10
    {
        public static void Executar()
        {
            // Caminho do arquivo
            string caminhoArquivo = "numeros.txt";

            // Verifica se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                if (linhas.Length > 0)
                {
                    double valorMaximo = double.MinValue;
                    double valorMinimo = double.MaxValue;
                    double soma = 0;

                    // Itera sobre as linhas para determinar o valor máximo, o valor mínimo e a soma dos valores
                    foreach (string linha in linhas)
                    {
                        if (double.TryParse(linha, out double valor))
                        {
                            if (valor > valorMaximo)
                                valorMaximo = valor;

                            if (valor < valorMinimo)
                                valorMinimo = valor;

                            soma += valor;
                        }
                    }

                    // Calcula a média
                    double media = soma / linhas.Length;

                    // Exibe os resultados na tela
                    Console.WriteLine($"Valor máximo: {valorMaximo}");
                    Console.WriteLine($"Valor mínimo: {valorMinimo}");
                    Console.WriteLine($"Média: {media}");
                }
                else
                {
                    Console.WriteLine("O arquivo está vazio.");
                }
            }
            else
            {
                Console.WriteLine("O arquivo não existe.");
            }
        }
    }
}
