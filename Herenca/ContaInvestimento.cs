

namespace Heranca
{
  public class ContaInvestimento : ContaRendimento, IContaInvestimento
  {
    public ContaInvestimento() { }
    public ContaInvestimento(double depositoInicial) : base(depositoInicial)
    {
      GerarAgenciaNumero();
      RenderCashBack();
    }

    public double PorcentagemCashBack { get; set; }

    public void RenderCashBack()
    {
      base.Saldo *= PorcentagemCashBack;
    }
  }
}
