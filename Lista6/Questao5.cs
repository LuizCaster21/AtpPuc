using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao5
    {
        public static void Executar()
        {
            // Solicita ao usuário o caminho do arquivo de texto
            Console.WriteLine("Digite o caminho do arquivo de texto:");
            string caminhoArquivo = Console.ReadLine();

            // Chama a função para imprimir o conteúdo do arquivo e contar as linhas
            ImprimirConteudoArquivo(caminhoArquivo);
        }

        static void ImprimirConteudoArquivo(string caminhoArquivo)
        {
            try
            {
                // Abre o arquivo para leitura
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    int contadorLinhas = 0;
                    string linha;

                    // Lê cada linha do arquivo
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Imprime a linha na tela
                        Console.WriteLine(linha);

                        // Incrementa o contador de linhas
                        contadorLinhas++;
                    }

                    // Exibe a quantidade de linhas do arquivo
                    Console.WriteLine($"Quantidade de linhas: {contadorLinhas}");
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de falha ao ler o arquivo
                Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
            }
        }
    }
}
