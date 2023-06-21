using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            //Substituir as variaveis
            string fraseSemVogais = RemoverVogais(frase);

            // Retornar o resultado
            Console.WriteLine("Frase sem vogais: " + fraseSemVogais);
        }

        static string RemoverVogais(string frase)
        {
            // Definindo as vogais em minúsculas e maiúsculas
            string vogais = "aeiouAEIOU"; 
            string novaFrase = "";

            foreach (char caracter in frase)
            {
                // Verificando se o caractere não é uma vogal
                if (!vogais.Contains(caracter)) 
                {
                    // Adicionando o caractere à nova frase
                    novaFrase += caracter; 
                }
            }

            // Retornando a nova frase sem vogais
            return novaFrase; 
        }
    }
}
