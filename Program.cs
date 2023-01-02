using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("     CRONÔMETRO     ");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.WriteLine("   S - Segundo - Ex: 10s");
            Console.WriteLine("   M - Minuto - Ex: 1m");
            Console.WriteLine("   0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Escolha sua opção?");
            Console.WriteLine("-------------------");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);
            
            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar ...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar ...");
            Thread.Sleep(1000);
            Console.WriteLine("Vai ...");
            Thread.Sleep(1000);
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado!");
            Thread.Sleep(1000);
            Menu();
        }
    }
}