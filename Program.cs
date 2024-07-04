using System;
using System.Threading;

namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minutos");
        Console.WriteLine("0 = Sair!");
        Console.WriteLine("---");
        Console.WriteLine("Quanto tempo deseja contar? (Exemplo: 5s ou 2m)");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
        {
            multiplier = 60;
        }
        else if (type != 's')
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            Thread.Sleep(1200);
            Menu();
            return;
        }
        if (time == 0)
        {
            System.Environment.Exit(0);
        }

        PreStart(time * multiplier);

    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1500);
        Console.WriteLine("Set...");
        Thread.Sleep(1500);
        Console.WriteLine("Go!...");
        Thread.Sleep(2500);

        Start(time);

    }

    static void Start(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado");
        Thread.Sleep(2500);
        Menu();
    }
}