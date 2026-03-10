using System;

class Program {
    static void Main() {
        double raio, area;
        const double pi = 3.14159;

        raio = double.Parse(Console.ReadLine());

        area = pi * (raio * raio);

        Console.WriteLine("AREA = " + area.ToString("F4"));
    }
}