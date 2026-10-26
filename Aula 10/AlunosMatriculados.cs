using System;

namespace Aula10
{
    public class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public double NotaProva1 { get; set; }
        public double NotaProva2 { get; set; }
        public double NotaTrabalho { get; set; }

        public Aluno(string matricula, string nome, double notaProva1, double notaProva2, double notaTrabalho)
        {
            Matricula = matricula;
            Nome = nome;
            NotaProva1 = notaProva1;
            NotaProva2 = notaProva2;
            NotaTrabalho = notaTrabalho;
        }

        // Calcula a média ponderada (Provas peso 2.5, Trabalho peso 2)[cite: 67]
        public double Media()
        {
            return ((NotaProva1 * 2.5) + (NotaProva2 * 2.5) + (NotaTrabalho * 2.0)) / 7.0;
        }

        // Retorna quanto falta para a final, ou 0 se a média for >= 60[cite: 67]
        public double Final()
        {
            double m = Media();
            if (m >= 60.0)
            {
                return 0.0;
            }
            return 60.0 - m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a matrícula do aluno: ");
            string mat = Console.ReadLine();

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota da Prova 1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da Prova 2: ");
            double p2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do Trabalho: ");
            double t = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(mat, nome, p1, p2, t);

            double mediaFinal = aluno.Media();
            Console.WriteLine($"\n--- Resultado ---");
            Console.WriteLine($"Aluno: {aluno.Nome} ({aluno.Matricula})");
            Console.WriteLine($"Média Final: {mediaFinal:F2}");

            double precisaFinal = aluno.Final();
            if (precisaFinal == 0.0)
            {
                Console.WriteLine("Situação: Aprovado direto!");
            }
            else
            {
                Console.WriteLine($"Situação: Prova Final (Precisa de {precisaFinal:F2} pontos)");
            }
        }
    }
}