using Calculadora;
using CalculadoraTeste;
using System;

namespace Modulo01;

public class OperacoesCalculadora
{
    public void RealizarCalculo()
    {
        CalculadoraClass calculadora = new CalculadoraClass();


        while (true)
        {
            Console.WriteLine("### Calculadora ###");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine($"Resultado da Soma: {calculadora.Soma(num1, num2)}");
                    break;

                case 2:
                    Console.WriteLine($"Resultado da Subtração: {calculadora.Subtracao(num1, num2)}");
                    break;

                case 3:
                    Console.WriteLine($"Resultado da Multiplicação: {calculadora.Multiplicacao(num1, num2)}");
                    break;

                case 4:
                    Console.WriteLine($"Resultado da Divisão: {calculadora.Divisao(num1, num2)}");
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }



            // Adicione a opção para continuar ou sair do loop
            Console.WriteLine("Deseja continuar Calculando? (S/N)");
            string continuar = Console.ReadLine().Trim().ToUpper();
            if (continuar != "S")
                break;
        }
    }

    public void RealizarTeste()
    {
        CalculadoraTestar calculadoraTeste = new CalculadoraTestar();

        while (true)
        {
            Console.WriteLine("### Testes ###");
            Console.WriteLine("Escolha o teste:");
            Console.WriteLine("1 - Testar Soma");
            Console.WriteLine("2 - Testar Subtração");
            Console.WriteLine("3 - Testar Multiplicação");
            Console.WriteLine("4 - Testar Divisão");

            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    calculadoraTeste.TestarSoma(num1, num2);
                    break;

                case 2:
                    calculadoraTeste.TestarSubtracao(num1, num2);
                    break;

                case 3:
                    calculadoraTeste.TestarMultiplicacao(num1, num2);
                    break;

                case 4:
                    calculadoraTeste.TestarDivisao(num1, num2);
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }




            // Adicione a opção para continuar ou sair do loop
            Console.WriteLine("Deseja continuar testando? (S/N)");
            string continuar = Console.ReadLine().Trim().ToUpper();
            if (continuar != "S")
                break;
        }
    }
}

