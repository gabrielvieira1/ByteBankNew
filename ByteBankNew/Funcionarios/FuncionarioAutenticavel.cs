using ByteBankNew.Funcionarios;
using ByteBankNew.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew
{
  public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
  {
    public string Senha { get; set; }

    protected FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf) { }

    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
  }
}
