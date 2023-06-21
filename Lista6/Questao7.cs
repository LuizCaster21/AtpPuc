using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao7
    {
        public static void Executar()
        {
            // Solicita ao usuário a quantidade de letras
            Console.WriteLine("Digite a quantidade de letras:");
            int quantidadeLetras = int.Parse(Console.ReadLine());

            // Insere as letras no arquivo
            InserirLetrasEmArquivo(quantidadeLetras);

            // Lê as letras do arquivo e calcula a quantidade de vogais
            CalcularQuantidadeVogais();
        }

        static void InserirLetrasEmArquivo(int quantidadeLetras)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("letras.txt"))
                {
                    for (int i = 0; i < quantidadeLetras; i++)
                    {
                        Console.WriteLine("Digite uma letra:");
                        char letra = Console.ReadLine()[0];
                        sw.Write(letra);
                    }
                }

                Console.WriteLine("Letras inseridas com sucesso no arquivo 'letras.txt'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao inserir as letras no arquivo: " + ex.Message);
            }
        }

        static void CalcularQuantidadeVogais()
        {
            try
            {
                using (StreamReader sr = new StreamReader("letras.txt"))
                {
                    string letras = sr.ReadToEnd();
                    int quantidadeVogais = 0;

                    foreach (char letra in letras)
                    {
                        if (EhVogal(letra))
                        {
                            quantidadeVogais++;
                        }
                    }

                    Console.WriteLine($"Quantidade de vogais: {quantidadeVogais}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao ler as letras do arquivo: " + ex.Message);
            }
        }

        static bool EhVogal(char letra)
        {
            letra = char.ToLower(letra);
            return letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u';
        }
    }
}
