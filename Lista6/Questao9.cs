using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Questao9
    {
        public static void Executar()
        {
            List<Aluno> alunos = new List<Aluno>();

            // Exibe as opções para o usuário
            Console.WriteLine("1 - Inserir dados de alunos");
            Console.WriteLine("2 - Ler dados de alunos de arquivo");
            Console.WriteLine("3 - Sair");

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nDigite a opção desejada (1, 2 ou 3):");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirDadosAlunos(alunos);
                        break;
                    case "2":
                        LerDadosAlunos();
                        break;
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite novamente.");
                        break;
                }
            }
        }

        static void InserirDadosAlunos(List<Aluno> alunos)
        {
            Console.WriteLine("\nInserção de dados de alunos");
            Console.WriteLine("Digite 'sair' para encerrar a inserção");

            bool encerrar = false;
            while (!encerrar)
            {
                Console.WriteLine("\nDigite a matrícula do aluno:");
                string matricula = Console.ReadLine();

                if (matricula.ToLower() == "sair")
                {
                    encerrar = true;
                    continue;
                }

                Console.WriteLine("Digite o telefone do aluno:");
                string telefone = Console.ReadLine();

                alunos.Add(new Aluno(matricula, telefone));
            }

            // Armazena os dados dos alunos em um arquivo texto
            GravarDadosAlunos(alunos);
        }

        static void GravarDadosAlunos(List<Aluno> alunos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("alunos.txt"))
                {
                    foreach (Aluno aluno in alunos)
                    {
                        // Escreve os dados do aluno no arquivo, separados por vírgula
                        sw.WriteLine($"{aluno.Matricula},{aluno.Telefone}");
                    }
                }

                Console.WriteLine("Dados dos alunos gravados com sucesso no arquivo 'alunos.txt'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados dos alunos no arquivo: " + ex.Message);
            }
        }

        static void LerDadosAlunos()
        {
            try
            {
                using (StreamReader sr = new StreamReader("alunos.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Divide a linha em matrícula e telefone, separados por vírgula
                        string[] dados = linha.Split(',');
                        string matricula = dados[0];
                        string telefone = dados[1];

                        Console.WriteLine($"Matrícula: {matricula}, Telefone: {telefone}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao ler os dados dos alunos do arquivo: " + ex.Message);
            }
        }
    }

    class Aluno
    {
        public string Matricula { get; set; }
        public string Telefone { get; set; }

        public Aluno(string matricula, string telefone)
        {
            Matricula = matricula;
            Telefone = telefone;
        }
    }
}
