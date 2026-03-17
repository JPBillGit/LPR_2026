using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um númer inteiro: ");

        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é um número par :3");
        }
        else
        {
            Console.WriteLine($"{numero} é um número ímpar >:(");
        }
        }
    }
