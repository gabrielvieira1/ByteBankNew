using ByteBankNew.Funcionarios;
using ByteBankNew.Sistema;
using System;

namespace ByteBankNew
{
  class Program
  {
    static void Main(string[] args)
    {
      CalcularBonificacao();
      UsarSistema();

      Console.ReadLine();

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
