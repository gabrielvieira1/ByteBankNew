using ByteBankNew.Funcionarios;
using System;

namespace ByteBankNew.Sistema
{
  public interface IAutenticavel
  {
    bool Autenticar(string senha);
  }
}