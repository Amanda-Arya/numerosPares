using System;

namespace numerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void ListarPares()
        {
            Console.Clear();
            int number, i;
            Console.WriteLine("Os números pares de 0 a 100 são:");

            for (i = 0; i <= 100; i++)
            {
                number = i % 2;
                if (number % 2 == 0)
                {
                    Console.Write($"{i},");
                }
            }
            Menu();
        }
        static void ListarImpares()
        {
            Console.Clear();
            int number, i;
            Console.WriteLine("Os números ímpares de 0 a 100 são:");

            for (i = 0; i <= 100; i++)
            {
                number = i % 2;
                if (number % 2 != 0)
                {
                    Console.Write($"{i},");
                }
            }
            Menu();
        }

        static void ListarPrimos()
        {
            Console.Clear();

            int divisor, rest, i;
            Console.WriteLine("Os números primos de 0 a 100 são:");

            divisor = 1;

            for (i = 1; i <= 100; i++)
            {
                rest = i % divisor;

                while (divisor =1; divisor <= 100; divisor++)
                {
                   rest = i % divisor;
                
                    Console.WriteLine(i);

                }
            }

            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" Escolha uma das opções:");

            Console.WriteLine(" 1- Listar números pares");
            Console.WriteLine(" 2- Listar números ímpares ");
            Console.WriteLine(" 3- Listar números primos");
            Console.WriteLine(" 4- Sair");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: ListarPares(); break;
                case 2: ListarImpares(); break;
                case 3: ListarPrimos(); break;
                case 4: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
}
