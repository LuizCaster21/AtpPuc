using System;

namespace Lista6
{
    internal class Questao1
    {
        public static void Executar()
        {
            Console.WriteLine("Questão 1:");
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            int contadorEspacos = ContarEspacos(frase);

            Console.WriteLine($"A frase possui {contadorEspacos} espaços em branco.");
        }

        static int ContarEspacos(string frase)
        {
            int contador = 0;

            foreach (char caracter in frase)
            {
                if (caracter == ' ')
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
