using ByteBankNew.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew.Funcionarios
{
  public class Diretor : FuncionarioAutenticavel
  {
    public Diretor(string cpf) : base(5000, cpf) { }

    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }

    public override double GetBonificacao()
    {
      return Salario * 0.5;
    }
  }
}
