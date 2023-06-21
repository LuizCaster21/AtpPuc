using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao4
    {
        public static void Executar()
        {
            // Solicita ao usuário o caminho do arquivo de texto
            Console.WriteLine("Digite o caminho do arquivo de texto:");
            string caminhoArquivo = Console.ReadLine();

            // Chama a função para contar a quantidade de caracteres 'a' no arquivo
            int quantidadeCaracteresA = ContarCaracteresA(caminhoArquivo);

            // Exibe a quantidade de caracteres 'a' na tela
            Console.WriteLine($"Quantidade de caracteres 'a': {quantidadeCaracteresA}");
        }

        static int ContarCaracteresA(string caminhoArquivo)
        {
            // Inicializa a variável de contagem de caracteres 'a'
            int quantidadeCaracteresA = 0;

            try
            {
                // Abre o arquivo para leitura
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Chama a função para contar a quantidade de caracteres 'a' em uma linha
                        quantidadeCaracteresA += ContarCaracteresAEmLinha(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de falha ao ler o arquivo
                Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
            }

            // Retorna a quantidade total de caracteres 'a' encontrados no arquivo
            return quantidadeCaracteresA;
        }

        static int ContarCaracteresAEmLinha(string linha)
        {
            // Inicializa a variável de contagem de caracteres 'a' em uma linha
            int quantidadeCaracteresA = 0;

            foreach (char caracter in linha)
            {
                // Verifica se o caractere é 'a' (minúsculo) ou 'A' (maiúsculo)
                if (caracter == 'a' || caracter == 'A')
                {
                    // Incrementa a quantidade de caracteres 'a' encontrados
                    quantidadeCaracteresA++;
                }
            }

            // Retorna a quantidade de caracteres 'a' encontrados na linha
            return quantidadeCaracteresA;
        }
    }
}
