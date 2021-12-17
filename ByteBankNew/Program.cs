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
      TratarStrings();
      //TratarArrayListas();
    }
    public static void TratarStrings()
    {
      try
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

        string urlVazia = "";
        ExtratorValorDeArgumentosURL extratorDeValores2 = new ExtratorValorDeArgumentosURL(urlVazia);
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine("Argumento com problema: " + ex.ParamName);
        Console.WriteLine(ex.Message);
      }
      Console.ReadLine();
    }

    public static void TratarArrayListas()
    {
      ListaDeFuncionarios lista = new ListaDeFuncionarios();

      Desenvolvedor desenvolvedor = new Desenvolvedor("Gabriel", "243.842.924-43");
      lista.Adicionar(desenvolvedor);
      lista.Adicionar(new Auxiliar("Pedro", "343.454.902-40"));
      lista.Adicionar(new Designer("Joana", "243.902.728-39"));
      lista.Adicionar(new Diretor("Bruna", "062.342.677-09"));

      lista.EscreverListaNaTela();

      lista.Remover(desenvolvedor);

      Console.WriteLine("------");

      lista.EscreverListaNaTela();

      Console.ReadLine();

    }

    //public static void UsarSistema()
    //{
    //  SistemaInterno sistemaInterno = new SistemaInterno();

    //  //Auxiliar igor = new Auxiliar("981.198.778-53");
    //  //igor.Nome = "Igor";
    //  //igor.Senha = "123";

    //  Diretor roberta = new Diretor("159.753.398-04");
    //  roberta.Nome = "Roberta";
    //  roberta.Senha = "123";

    //  GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
    //  camila.Nome = "Camila";
    //  camila.Senha = "123";

    //  ParceiroComercial parceiro = new ParceiroComercial();
    //  parceiro.Senha = "1234";

    //  //sistemaInterno.Logar(igor, "123");
    //  sistemaInterno.Logar(roberta, "123");
    //  sistemaInterno.Logar(camila, "1234");
    //  sistemaInterno.Logar(parceiro, "1234");

    //}

    //public static void CalcularBonificacao()
    //{
    //  GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

    //  Designer pedro = new Designer("833.222.048-39");
    //  pedro.Nome = "Pedro";

    //  Diretor roberta = new Diretor("159.753.398-04");
    //  roberta.Nome = "Roberta";

    //  Auxiliar igor = new Auxiliar("981.198.778-53");
    //  igor.Nome = "Igor";

    //  GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
    //  camila.Nome = "Camila";

    //  Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
    //  guilherme.Nome = "Guilherme";

    //  gerenciadorBonificacao.Registrar(guilherme);
    //  gerenciadorBonificacao.Registrar(pedro);
    //  gerenciadorBonificacao.Registrar(roberta);
    //  gerenciadorBonificacao.Registrar(igor);
    //  gerenciadorBonificacao.Registrar(camila);

    //  Console.WriteLine("Nome: " + pedro.Nome);
    //  Console.WriteLine("Salario: " + pedro.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + roberta.Nome);
    //  Console.WriteLine("Salario: " + roberta.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + igor.Nome);
    //  Console.WriteLine("Salario: " + igor.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + camila.Nome);
    //  Console.WriteLine("Salario: " + camila.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + guilherme.Nome);
    //  Console.WriteLine("Salario: " + guilherme.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao().ToString("C") + "\n");

    //  pedro.AumentarSalario();
    //  roberta.AumentarSalario();
    //  igor.AumentarSalario();
    //  camila.AumentarSalario();
    //  guilherme.AumentarSalario();

    //  Console.WriteLine("Nome: " + pedro.Nome);
    //  Console.WriteLine("Salario: " + pedro.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + roberta.Nome);
    //  Console.WriteLine("Salario: " + roberta.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + igor.Nome);
    //  Console.WriteLine("Salario: " + igor.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + camila.Nome);
    //  Console.WriteLine("Salario: " + camila.Salario.ToString("C") + "\n");
    //  Console.WriteLine("Nome: " + guilherme.Nome);
    //  Console.WriteLine("Salario: " + guilherme.Salario.ToString("C") + "\n");
    //}
  }
}
