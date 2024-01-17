namespace Conta;

public class ClassConta
{
    public int Agencia { get; set; }
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public int Idade { get; set; }
    public string? CPF { get; set; }
    public decimal Saldo { get;  set; }

    public ClassConta() { }

    public bool Depositar(decimal valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("O valor do depósito deve ser positivo.");
            return false;
        }

        Saldo += valor;
        return true;
    }

    public bool Sacar(decimal valor)
    {
        if (valor < 0)
        {
            return false;
        }

        if (Saldo < valor)
        {
            return false;
            
        }

        if (valor > Saldo)
        {
            return false;
        }

        Saldo -= valor;
        return true;
    }

}
