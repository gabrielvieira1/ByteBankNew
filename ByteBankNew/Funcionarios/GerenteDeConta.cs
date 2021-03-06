using ByteBankNew.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew.Funcionarios
{
  public class GerenteDeConta : FuncionarioAutenticavel
  {
    public GerenteDeConta(string nome, string cpf) : base(4000, nome, cpf) { }

    public override void AumentarSalario()
    {
      Salario *= 1.05;
    }

    public override double GetBonificacao()
    {
      return Salario * 0.25;
    }

    public override string ToString()
    {
      return $"Gerente de contas: {Nome}, CPF: {CPF}, Salário: {Salario}";
    }
  }
}
