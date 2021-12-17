using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew.Funcionarios
{
  public class Auxiliar : Funcionario
  {
    public Auxiliar(string nome, string cpf) : base(2000, nome, cpf) { }

    public override void AumentarSalario()
    {
      Salario *= 1.1;
    }

    public override double GetBonificacao()
    {
      return Salario * 0.2;
    }
    public override string ToString()
    {
      return $"Auxiliar: {Nome}, CPF: {CPF}, Salário: {Salario}";
    }
  }
}
