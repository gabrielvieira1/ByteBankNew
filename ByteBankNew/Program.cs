using ByteBankNew.Funcionarios;
using ByteBankNew.Sistema;
using System;
using System.Text.RegularExpressions;

namespace ByteBankNew
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        TratarStrings();

      }
      catch (ArgumentException ex)
      {
        Console.WriteLine("Argumento com problema: " + ex.ParamName);
        Console.WriteLine(ex.Message);
      }
      Console.ReadLine();
    }

    public static void TratarStrings()
    {
      string urlParametros = "https://www.bytebank.com/cambio?nome=Gabriel&moedaOrigem=real&moedaDestino=dolar&valor=1500";
      ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

      string usuario = extratorDeValores.GetParametro("nome");
      string msg = "Olá nome";
      Console.WriteLine(msg.Replace("nome", usuario) + "\n");

      string valorMoedaDestino = extratorDeValores.GetParametro("moedaDestino");
      Console.WriteLine("Moeda destino: " + valorMoedaDestino + "\n");

      string valorMoedaOrigem = extratorDeValores.GetParametro("moedaOrigem");
      Console.WriteLine("Moeda origem: " + valorMoedaOrigem + "\n");

      string valor = extratorDeValores.GetParametro("VALOR");
      Console.WriteLine("Valor: " + valor + "\n");


      //string urlTeste = "https://www.bytebank.com/teste?nome=Gabriel&moedaOrigem=real&moedaDestino=dolar&valor=1500";
      //ExtratorValorDeArgumentosURL extratorDeValores2 = new ExtratorValorDeArgumentosURL(urlTeste);
      //Console.WriteLine(extratorDeValores2);

      //UsuarioCambio usuarioCambio = new UsuarioCambio("Gabriel", "123.123.232-23");

      //UsuarioCambio usuarioCambio2 = new UsuarioCambio("Gabriel", "123.123.232-23");

      //Desenvolvedor desenvolvedor = new Desenvolvedor("123.123.232-23");
      //desenvolvedor.Nome = "Gabriel";

      //if (usuarioCambio.Equals(usuarioCambio2))
      //{
      //  Console.WriteLine("Você só poderá usar o nosso cambio daqui a 10 minutos");
      //  Console.WriteLine(usuarioCambio2 + "\n");
      //}

      //if (!usuarioCambio.Equals(desenvolvedor))
      //{
      //  Console.WriteLine("Funcionários não podem usar o cambio");
      //  Console.WriteLine(desenvolvedor);
      //}

    }

    public static void UsarSistema()
    {
      SistemaInterno sistemaInterno = new SistemaInterno();

      //Auxiliar igor = new Auxiliar("981.198.778-53");
      //igor.Nome = "Igor";
      //igor.Senha = "123";

      Diretor roberta = new Diretor("159.753.398-04");
      roberta.Nome = "Roberta";
      roberta.Senha = "123";

      GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
      camila.Nome = "Camila";
      camila.Senha = "123";

      ParceiroComercial parceiro = new ParceiroComercial();
      parceiro.Senha = "1234";

      //sistemaInterno.Logar(igor, "123");
      sistemaInterno.Logar(roberta, "123");
      sistemaInterno.Logar(camila, "1234");
      sistemaInterno.Logar(parceiro, "1234");

    }

    public static void CalcularBonificacao()
    {
      GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

      Designer pedro = new Designer("833.222.048-39");
      pedro.Nome = "Pedro";

      Diretor roberta = new Diretor("159.753.398-04");
      roberta.Nome = "Roberta";

      Auxiliar igor = new Auxiliar("981.198.778-53");
      igor.Nome = "Igor";

      GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
      camila.Nome = "Camila";

      Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
      guilherme.Nome = "Guilherme";

      gerenciadorBonificacao.Registrar(guilherme);
      gerenciadorBonificacao.Registrar(pedro);
      gerenciadorBonificacao.Registrar(roberta);
      gerenciadorBonificacao.Registrar(igor);
      gerenciadorBonificacao.Registrar(camila);

      Console.WriteLine("Nome: " + pedro.Nome);
      Console.WriteLine("Salario: " + pedro.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + roberta.Nome);
      Console.WriteLine("Salario: " + roberta.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + igor.Nome);
      Console.WriteLine("Salario: " + igor.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + camila.Nome);
      Console.WriteLine("Salario: " + camila.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + guilherme.Nome);
      Console.WriteLine("Salario: " + guilherme.Salario.ToString("C") + "\n");
      Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao().ToString("C") + "\n");

      pedro.AumentarSalario();
      roberta.AumentarSalario();
      igor.AumentarSalario();
      camila.AumentarSalario();
      guilherme.AumentarSalario();

      Console.WriteLine("Nome: " + pedro.Nome);
      Console.WriteLine("Salario: " + pedro.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + roberta.Nome);
      Console.WriteLine("Salario: " + roberta.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + igor.Nome);
      Console.WriteLine("Salario: " + igor.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + camila.Nome);
      Console.WriteLine("Salario: " + camila.Salario.ToString("C") + "\n");
      Console.WriteLine("Nome: " + guilherme.Nome);
      Console.WriteLine("Salario: " + guilherme.Salario.ToString("C") + "\n");
    }
  }
}
