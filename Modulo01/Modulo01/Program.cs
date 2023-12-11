using Modulo01;

OperacoesCalculadora operacoes = new OperacoesCalculadora();

Console.WriteLine("### Exemplos Testes Unitarios ###");
Console.WriteLine("Escolha a operação:");
Console.WriteLine("1 - Projeto Calculadora e teste");
Console.WriteLine("2 - Projeto Banco e teste");

int escolha = Convert.ToInt32(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("### Exemplos Testes Unitarios CALCULADORA ###");

        Console.WriteLine("Deseja realizar cálculos ou testar a calculadora?");
        string opcao = Console.ReadLine().ToLower();

        switch (opcao)
        {
            case "testar":
                operacoes.RealizarTeste();
                break;

            case "calcular":
                operacoes.RealizarCalculo();
                break;

            default:
                Console.WriteLine("Opção inválida. Por favor, escolha 'Testar' ou 'Calcular'.");
                break;
        }

        break;

    case 2:
        Console.WriteLine("### Exemplos Testes Unitarios BANCO ###");
        // Adicione a lógica para o projeto Banco, se necessário
        break;

    default:
        Console.WriteLine("Opção inválida. Por favor, escolha 'Testar' ou 'Calcular'.");
        break;
}

Console.ReadLine();
