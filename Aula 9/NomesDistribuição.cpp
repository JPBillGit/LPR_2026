using System;
using System.Collections.Generic;

class Program
{
    static  void Main()
    {
        Console.Write("Digite a quantidade de nomes que voce deseja:");
        int totalNomes = int.Parse(Console.ReadLine());

        List<string> listaNomes = new List<string>();
        for (int i = 0; i < totalNomes; i++)
        {
            Console.Write($"Digite o nome {i + 1}:");
            listaNomes.Add(Console.ReadLine());
        }

        List<List<string>> matrizLinhas = new List<List<string>>();
        //lista que guarda outras listas de texto

        foreach(string nomeAtual in listaNomes)
        {
            bool encaixou = false;

            for (int i = 0; i < matrizLinhas.Count; i++)
            {
                bool temTamanhoIgual = false;

                foreach (string nomeNaLinha in matrizLinhas[i])
                //analisa se o tamanho do nome bate
                {
                    if (nomeAtual.Length == nomeNaLinha.Length)
                    {
                        temTamanhoIgual = true;
                        break; 
                        //ja tem um nome igual
                    }
                }

                if (!temTamanhoIgual)
                {
                    matrizLinhas[i].Add(nomeAtual);
                    encaixou = true;
                    break; 
                    //o nome encaixou
                }
            }
            if (!encaixou)
            //cria uma nova linha se todas as linhas nao conseguiu encaixar
            {
                List<string> novaLinha = new List<string>();
                novaLinha.Add(nomeAtual);
                matrizLinhas.Add(novaLinha);
            }
        }
        
        Console.WriteLine("\n Resultado da Distribuicao");
        for (int i = 0; i < matrizLinhas.Count; i++)
        {
            Console.Write($"Linha {i + 1}:");
            foreach (string nome in matrizLinhas[i])
            {
                Console.Write(nome + " ");
            }
            Console.WriteLine();
        }
    }
}