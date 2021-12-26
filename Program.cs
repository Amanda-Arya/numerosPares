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
            int divisor, numero, contador;
            contador = 0;
            for (numero = 1; numero <= 100; numero++)
            {

                for (divisor = 1; numero <= divisor; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine($"Números primos:{numero}");
                }

            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" Escolha uma das opções:");

            Console.WriteLine(" 1- Listar números pares");
            Console.WriteLine(" 2- Listar números ímpares ");
            Console.WriteLine(" 3- Listar números primos");
            Console.WriteLine(" 4- Sair");

            int opcao = Int32.Parse(Console.ReadLine());
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
