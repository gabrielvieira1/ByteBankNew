using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew.Funcionarios
{
  public class Designer : Funcionario
  {
    public Designer(string nome, string cpf) : base(3000, nome, cpf) { }

    public override void AumentarSalario()
    {
      Salario *= 1.11;
    }

    public override double GetBonificacao()
    {
      return Salario * 0.17;
    }
    public override string ToString()
    {
      return $"Designer: {Nome}, CPF: {CPF}, Salário: {Salario}";
    }
  }
}
