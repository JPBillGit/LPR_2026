using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma classe :>");
        Console.WriteLine("1- Guerreiro");
        Console.WriteLine("2- Mago");
        Console.WriteLine("3- Arqueiro");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Classe: Guerreiro");
                Console.WriteLine("Habilidades:");
                Console.WriteLine("- Golpe Poderoso");
                Console.WriteLine("- Defesa Total");
                break;

            case 2:
                Console.WriteLine("Classe: Mago");
                Console.WriteLine("Habilidades:");
                Console.WriteLine("- Bola de Fogo");
                Console.WriteLine("- Teletransporte");
                break;

            case 3:
                Console.WriteLine("Classe: Arqueiro");
                Console.WriteLine("Habilidades:");
                Console.WriteLine("- Flecha Precisa");
                Console.WriteLine("- Chuva de Flechas");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}