using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew.Funcionarios
{
  public abstract class Funcionario
  {
    public static int TotalDeFuncionarios { get; private set; }

    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }

    public Funcionario(double salario, string cpf)
    {
      TotalDeFuncionarios++;
      CPF = cpf;
      Salario = salario;
    }

    public abstract void AumentarSalario();

    public abstract double GetBonificacao();
  }
}
