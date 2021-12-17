using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew
{
  public class ExtratorValorDeArgumentosURL
  {
    private readonly string _argumentos;
    public string URL { get; }

    public ExtratorValorDeArgumentosURL(string url)
    {
      if (String.IsNullOrEmpty(url))
        throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));

      if (!url.StartsWith("https://www.bytebank.com"))
        throw new ArgumentException("A url só pode ser do bytebank.", nameof(url));

      if (!url.Contains("cambio"))
        throw new ArgumentException("Você deve acessar a área de cambio.", nameof(url));

      int indiceInterrogacao = url.IndexOf('?');
      _argumentos = url.Substring(indiceInterrogacao + 1);

      URL = url;
    }

    public string GetParametro(string nomeParametro)
    {
      nomeParametro = nomeParametro.ToUpper();
      string argumentosEmCaixaAlta = _argumentos.ToUpper();

      string termo = nomeParametro + "=";
      int indiceTermo = argumentosEmCaixaAlta.IndexOf(termo);

      string resultado = _argumentos.Substring(indiceTermo + termo.Length);
      int indiceEComercial = resultado.IndexOf('&');

      if (indiceEComercial == -1)
      {
        return resultado;
      }

      return resultado.Remove(indiceEComercial);
    }
  }
}
