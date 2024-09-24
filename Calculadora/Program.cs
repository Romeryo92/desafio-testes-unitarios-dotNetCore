using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("===================");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adição (+)");
                Console.WriteLine("2 - Subtração (-)");
                Console.WriteLine("3 - Multiplicação (*)");
                Console.WriteLine("4 - Divisão (/)");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "5")
                {
                    continuar = false;
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = Adicionar(num1, num2);
                        Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                        break;

                    case "2":
                        resultado = Subtrair(num1, num2);
                        Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                        break;

                    case "3":
                        resultado = Multiplicar(num1, num2);
                        Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                        break;

                    case "4":
                        if (num2 != 0)
                        {
                            resultado = Dividir(num1, num2);
                            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public static double Adicionar(double a, double b)
        {
            return a + b;
        }

        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

    }
}
