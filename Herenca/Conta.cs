using System;
using System.Collections.Generic;


namespace Heranca
{
  public abstract class Conta : IConta
  {
    public string Agencia { get; set; }
    public string Numero { get; set; }
    public double Saldo { get; set; }

    protected List<double> OperacoesEmConta;

    public Conta() { }


    public Conta(double depositoInicial)
    {
      Saldo += depositoInicial;
      GerarAgenciaNumero();
      OperacoesEmConta = new List<double>();
    }

    public void GerarAgenciaNumero()
    {
      Agencia = (new Random()).Next().ToString();
      Numero = (new Random()).Next().ToString();
    }

    public virtual void Depositar(double valor)
    {
      Saldo = +valor;

    }

    public void Transferir(double valor, Conta conta)
    { }

    public void Sacar(double valor)
    {
      if (valor <= Saldo)
      {
        Saldo -= valor;
      }
      else
      {
        Console.WriteLine("Saldo Insuficiente!");
      }
    }
  }
}

