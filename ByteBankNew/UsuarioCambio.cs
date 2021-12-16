using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew
{
  public class UsuarioCambio
  {
    public static int TotalDeUsuarios { get; private set; }

    public string Nome { get; set; }
    public string CPF { get; private set; }

    public UsuarioCambio(string nome, string cpf)
    {
      TotalDeUsuarios++;
      Nome = nome;
      CPF = cpf;
    }

    public override string ToString()
    {
      return $"Nome: {Nome}, CPF: {CPF}";
    }

    public override bool Equals(object obj)
    {
      UsuarioCambio usuarioCambio = obj as UsuarioCambio;

      if (usuarioCambio == null)
      {
        return false;
      }

      return CPF == usuarioCambio.CPF;
    }
  }
}
