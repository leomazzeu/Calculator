using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Soma();
            //Subtracao();
            //Divisao();
            Multiplicacao();
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

            Console.ReadLine();
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

            Console.ReadLine();
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

            Console.ReadLine();
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

            Console.ReadLine();
        }
    }
}
