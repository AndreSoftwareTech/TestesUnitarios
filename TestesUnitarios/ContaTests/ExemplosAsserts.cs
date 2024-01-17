using Conta;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaTests;

public class ExemplosAsserts
{

    [Test]
    public void VerificaVazio()
    {
        string s = "";
        Assert.IsEmpty(s);
    }
    [Test]
    public void VerificaNaoVazio()
    {
        string s = "NUnit";
        Assert.IsNotEmpty(s);
    }
    [Test]
    public void VerificaMaior()
    {
        int a = 10; 
        int b = 20; 

        Assert.Greater(b, a);
    }
    [Test]
    public void VerificaObjeto()
    {
        ClassConta c1 = new ClassConta();
        ClassConta c2 = new ClassConta();
        c1 = c2;

        Assert.AreSame(c1, c2);
    }
    [Test]
    public void VerificaNulo()
    {
        ClassConta c1 = new ClassConta();

        Assert.IsNotNull(c1);
    }
    [Test]
    public void VerificaNegativo()
    {
        int a = -10;
        Assert.Negative(a);
    }
}
