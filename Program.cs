using System;

namespace FuncoesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!!"); ///Função de execução, parametros
            //string hello = Console.ReadLine();///Função que retorna valor
            Console.WriteLine("Quadrado - Retângulo - Trapézio - Losango");
            string forma = Console.ReadLine().ToLower().Substring(0, 1);
            switch (forma)
            {
                case "q":
                    Quadrado();
                    break;
                case "r":
                    Retangulo();
                    break;
                case "t":
                    Trapezio();
                    break;
                case "l":
                    Losango();
                    break;
                default:
                    Console.WriteLine("erro");
                    break;
            }


            Console.ReadKey(); ///Funcão de execução
        }
        static void Quadrado()
        {
            Console.WriteLine("Digite a altura: ");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("A area do Quadrado é: " + (bas * bas));
        }
        static void Retangulo()
        {
            Console.WriteLine("Digite a altura: ");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base: ");
            double alt = double.Parse(Console.ReadLine());
            Console.WriteLine("A area do Retângulo é: " + (bas * alt));
        }

        static void Trapezio()
        {
            Console.WriteLine("Digite a altura: ");
            double alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base menor: ");
            double basm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base maior: ");
            double basM = double.Parse(Console.ReadLine());
            Console.WriteLine("A area do Trapézio é: " + ((basm + basM) * alt) / 2);
        }

        static void Losango()
        {
            Console.WriteLine("Digite a diagonal menor: ");
            double diam = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a diagonal maior: ");
            double diaM = double.Parse(Console.ReadLine());
            Console.WriteLine("A area do Losango é: " + (diam * diaM) / 2);
        }
    }
}
