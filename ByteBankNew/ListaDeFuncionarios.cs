using System;
using ByteBankNew.Funcionarios;
using System.Collections.Generic;
using System.Text;

namespace ByteBankNew
{
  class ListaDeFuncionarios
  {
    private Funcionario[] _funcionarios;
    private int _proximaPosicao;

    public ListaDeFuncionarios(int capacidadeInicial = 1)
    {
      _funcionarios = new Funcionario[capacidadeInicial];
      _proximaPosicao = 0;
    }

    public void Adicionar(Funcionario item)
    {
      VerificarCapacidade(_proximaPosicao + 1);

      _funcionarios[_proximaPosicao] = item;
      _proximaPosicao++;
    }

    public void Remover(Funcionario item)
    {
      int indiceItem = -1;

      for (int i = 0; i < _proximaPosicao; i++)
      {
        Funcionario itemAtual = _funcionarios[i];

        if (itemAtual.Equals(item))
        {
          indiceItem = i;
          break;
        }
      }

      for (int i = indiceItem; i < _proximaPosicao - 1; i++)
      {
        _funcionarios[i] = _funcionarios[i + 1];
      }

      _proximaPosicao--;
      _funcionarios[_proximaPosicao] = null;
    }

    public void EscreverListaNaTela()
    {
      for (int i = 0; i < _proximaPosicao; i++)
      {
        Funcionario funcionario = _funcionarios[i];
        Console.WriteLine($"Funcionário(a) no índice {i}: {funcionario.ToString()}");
      }
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
      if (_funcionarios.Length >= tamanhoNecessario)
      {
        return;
      }

      int novoTamanho = _funcionarios.Length * 2;
      if (novoTamanho < tamanhoNecessario)
      {
        novoTamanho = tamanhoNecessario;
      }

      Funcionario[] novoArray = new Funcionario[novoTamanho];

      Array.Copy(sourceArray: _funcionarios, destinationArray: novoArray, length: _funcionarios.Length);

      _funcionarios = novoArray;
    }

  }
}
