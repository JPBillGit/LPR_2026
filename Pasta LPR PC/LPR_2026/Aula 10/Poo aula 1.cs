using System;

namespace Aula10
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        public double CalcArea()
        {
            return Largura * Altura;
        }

        public double CalcPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }

    class Program
    {
        static void MainDesativado(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Digite a altura do retângulo:");
            ret.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a largura do retângulo:");
            ret.Largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Área: " + ret.CalcArea());
            Console.WriteLine("Perímetro: " + ret.CalcPerimetro());
        }
    }
}