using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de numeros que serao inseridos: ");
        int numeros = int.Parse(Console.ReadLine());

        int contador = 0;
        double somaPares = 0; 
        int quantidadePares = 0;

        while (contador < numeros)
        {
            Console.Write($"Digite o {contador + 1}º numero: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado % 2 == 0)
            {
                somaPares += numeroDigitado;
                quantidadePares++;
            }
            contador++;
        }

        
        if (quantidadePares > 0)
        {
            double media = somaPares / quantidadePares;
            Console.WriteLine($"\nQuantidade de numeros pares: {quantidadePares}");
            Console.WriteLine($"A media aritmetica dos pares é: {media}");
        }
        else
        {
            Console.WriteLine("\nNenhum numero par foi digitado.");
        }
    }
}