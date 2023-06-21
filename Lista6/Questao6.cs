using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao6
    {
        public static void Executar()
        {
            // Solicita ao usuário um número
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            // Obtém os divisores do número e salva a soma total em um arquivo
            SalvarDivisoresEmArquivo(numero);
        }

        static void SalvarDivisoresEmArquivo(int numero)
        {
            int somaDivisores = 0;

            try
            {
                using (StreamWriter sw = new StreamWriter("divisores.txt"))
                {
                    sw.WriteLine($"Divisores do número {numero}:");

                    // Encontra e imprime os divisores do número
                    for (int i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            sw.WriteLine(i);
                            somaDivisores += i;
                        }
                    }

                    sw.WriteLine($"Soma dos divisores: {somaDivisores}");
                }

                Console.WriteLine("Divisores salvos com sucesso no arquivo 'divisores.txt'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao salvar os divisores no arquivo: " + ex.Message);
            }
        }
    }
}
