using System;

namespace Heranca
{
  class Program
  {
    static void Main(string[] args)
    {
      var conta = new ContaCorrente(20);
      var contaNova = converterConta<ContaCorrente, ContaInvestimento>(conta);
      Console.WriteLine(contaNova.Saldo);
      Console.WriteLine(contaNova.Agencia);
      Console.WriteLine(conta.Saldo);
    }

    static K converterConta<T, K>(T contaOrigem)
    where T : Conta
    where K : Conta

    {

      K contaConvertida = Activator.CreateInstance<K>();

      contaConvertida.Agencia = contaOrigem.Agencia;
      contaConvertida.Numero = contaOrigem.Numero;

      contaConvertida.Depositar(contaOrigem.Saldo);

      contaOrigem = null;

      return contaConvertida;
    }

  }
}


