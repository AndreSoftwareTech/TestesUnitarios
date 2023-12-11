using Banco;

namespace BancoTeste;

public class TesteContaBancaria
{
    public void TestarDeposito(decimal valorteste)
    {
        ContaBancaria conta = new ContaBancaria();

        decimal saldoInicial = conta.Saldo;

        decimal novoSaldo = conta.Depositar(valorteste);

        if (novoSaldo != saldoInicial + valorteste)
        {
            Console.WriteLine("Erro: O saldo não foi atualizado corretamente após o depósito.");
        }

        // Tente depositar um valor negativo
        novoSaldo = conta.Depositar(-valorteste);

        if (novoSaldo != saldoInicial)
        {
            Console.WriteLine("Erro: O saldo não deve ser alterado por um depósito negativo.");
        }
    }

    public void TestarSaque(decimal valorteste)
    {
        ContaBancaria conta = new ContaBancaria();
        decimal saldoInicial = conta.Saldo;

        decimal novoSaldo = conta.Sacar(valorteste);

        if (novoSaldo > saldoInicial)
        {
            Console.WriteLine(" O saldo de saque e maior qu o valor em conta.");
        }

        novoSaldo = conta.Sacar(-valorteste);
        if (novoSaldo != saldoInicial)
        {
            Console.WriteLine("Erro: O saldo não deve ser alterado por um saque negativo.");
        }

        novoSaldo = conta.Sacar(saldoInicial);
        if (novoSaldo != 0)
        {
            Console.WriteLine("Erro: O saldo não foi zerado corretamente após um saque igual ao saldo.");
        }

    }

}
