using Conta;

namespace Project_NUnit;

public class Tests
{

    [Test]
    public void TestConta()
    {
        ClassConta conta = new ClassConta();
        conta.Saldo = 1500.0M;

        bool resultado = conta.Sacar(500);

        Assert.IsTrue(resultado);
    }
}
}