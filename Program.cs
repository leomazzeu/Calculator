using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma Opção:");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é: {resultado}");

            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro número:");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Menu();
        }
    }
}
