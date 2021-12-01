using ByteBankNew.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew
{
  public class ParceiroComercial : IAutenticavel
  {
    public string Senha { get; set; }
    public bool Autenticar (string senha)
    {
      return Senha == senha;
    }
  }
}
