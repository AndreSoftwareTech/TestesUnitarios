using System;

namespace CalculadoraTeste
{
    public class CalculadoraTestar
    {

        public  void TestarSoma(int a, int b)
        {
            var calculadora = new Calculadora.CalculadoraClass();
            int resultadoEsperado = a + b;

            int resultado = calculadora.Soma(a, b);
            VerificarResultado("Soma", resultado, resultadoEsperado);
        }

        public void TestarSubtracao(int a, int b)
        {
            var calculadora = new Calculadora.CalculadoraClass();

            // Verificar a subtração onde b > a
            if (b > a)
            {
                Console.WriteLine("Erro: O segundo número não pode ser maior que o primeiro para a subtração.");
            }
            if(a == 0)
            {
                Console.WriteLine("O Primeiro numero nao pode ser Zero");
            }
            else
            {
                int resultadoEsperado = a - b;
                int resultado = calculadora.Subtracao(a, b);
                VerificarResultado("Subtração", resultado, resultadoEsperado);
            }
        }


        public void TestarMultiplicacao(int a, int b)
        {
            var calculadora = new Calculadora.CalculadoraClass();

            // Verificar multiplicação resultando em overflow de int
            // A condição a seguir verifica se a multiplicação resultará em overflow:
            // 1. (b != 0 && a > int.MaxValue / b): quando 'b' não é zero e 'a' é maior que o quociente máximo de int.MaxValue / b.
            // 2. (a == int.MinValue && b == -1): quando 'a' é int.MinValue e 'b' é -1, o qual resulta em overflow.
            if ((b != 0 && a > int.MaxValue / b) || (a == int.MinValue && b == -1))
            {
                Console.WriteLine("Erro: Multiplicação resulta em overflow de int.");
            }
            else
            {
                int resultadoEsperado = a * b;
                int resultado = calculadora.Multiplicacao(a, b);
                VerificarResultado("Multiplicação", resultado, resultadoEsperado);
            }
        }


        public void TestarDivisao(int a, int b)
        {
            var calculadora = new Calculadora.CalculadoraClass();

            // Verificar entrada válida
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            else if (a < 0 || b < 0)
            {
                Console.WriteLine("Erro: Os números devem ser positivos para a divisão.");
            }
            else
            {
                // Verificar divisão por zero
                    int resultadoEsperado = a / b;
                    int resultado = calculadora.Divisao(a, b);
                    VerificarResultado("Divisão", resultado, resultadoEsperado);
             }
            
        }

        public void VerificarResultado(string operacao, int resultado, int resultadoEsperado)
        {
            Console.WriteLine($"Resultado da {operacao}: {resultado}");

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine($"O resultado da {operacao} está correto.");
            }
            else
            {
                Console.WriteLine($"Erro na {operacao}: Esperado {resultadoEsperado}, Obtido {resultado}");
            }

            Console.WriteLine();
        }
    }
}
