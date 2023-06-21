using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao3
    {
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Declarar variaveis
            string fraseCodificada = CodificarCesar(frase);

            //retornar o resultado
            Console.WriteLine("Frase codificada: " + fraseCodificada);
        }

        static string CodificarCesar(string frase)
        {
            string fraseCodificada = "";

            foreach (char caracter in frase)
            {
                // Verifica se o caractere é uma letra
                if (char.IsLetter(caracter))
                {
                    // Desloca o caractere em 3 posições no alfabeto
                    char caracterCodificado = (char)(caracter + 3);

                    // Garante que o caractere esteja no alfabeto, considerando a rotação
                    if (!char.IsLetterOrDigit(caracterCodificado) || char.IsWhiteSpace(caracter))
                    {
                        caracterCodificado = (char)(caracterCodificado - 26);
                    }

                    // Constrói a frase codificada
                    fraseCodificada += caracterCodificado;
                }
                else
                {
                    // Mantém outros caracteres intactos
                    fraseCodificada += caracter;
                }
            }

            // Retorna a frase codificada
            return fraseCodificada;
        }
    }
}
