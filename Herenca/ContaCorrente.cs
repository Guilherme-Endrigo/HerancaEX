using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
  public class ContaCorrente : Conta
  {
    public ContaCorrente() { }

    public ContaCorrente(double depositoInicial) : base(depositoInicial)
    {
      GerarAgenciaNumero();
    }

  }
}

