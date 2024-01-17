using Conta;
using NUnit.Framework;

namespace ContaTests;

public class Tests
{


    [Test]
    public void TestSacar()
    {
        ClassConta conta = new ClassConta();
        conta.Saldo = 1500.0M;

        bool resultado = conta.Sacar(500);

        Assert.IsTrue(resultado);
    }
    [Test]
    public void TestSacarSemSaldo()
    {
        ClassConta conta = new ClassConta();
        conta.Saldo = 500.0M;

        bool resultado = conta.Sacar(600);

        Assert.IsFalse(resultado);
    }
    //[ignore("Mensagem referenciando a pendencia")]

    [Test]
    public void TestSacarNegativo()
    {
        ClassConta conta = new ClassConta();
        conta.Saldo = 500.0M;

        bool resultado = conta.Sacar(-100);

        Assert.IsFalse(resultado);
    }
}