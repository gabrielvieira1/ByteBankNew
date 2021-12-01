using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew.Sistema
{
  public class SistemaInterno
  {
    public bool Logar(IAutenticavel autenticavel, string senha)
    {
      bool usuarioAutenticado = autenticavel.Autenticar(senha);

      if (!usuarioAutenticado)
      {
        Console.WriteLine("Senha incorreta");
        return false;
      }
      Console.WriteLine("Bem-vindo");
      return true;
    }
  }
}
