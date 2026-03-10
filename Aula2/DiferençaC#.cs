using System;
class Program
{
    static void Main()
    {
        int A, B, C, D;
        int diferenca;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        diferenca = (A * B) - (C * D);
        Console.WriteLine("Difrença = " + diferenca);
    }
}