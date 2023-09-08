namespace ByteBank1.Model.Entities;

public class Conta
{

  // get - visualização
  // set - alteração

  // atributos
  public long Id { get; private set; }
  public string Cpf { get; private set; } = null!;
  public string Senha { get; private set; } = null!;
  public double Saldo { get; private set; }
  public bool EstaBloqueada { get; protected set; }

  // construtor
  public Conta(long id, string cpf, string senha)
  {
    Id = id;
    Cpf = cpf;
    Senha = senha;
    Saldo = 0.0;
    EstaBloqueada = false;
  }

  // métodos
  public void Depositar(double quantia)
  {
    Saldo += quantia;
  }

  public void Sacar(double quantia)
  {
    Saldo -= quantia;
  }

  public void Transferir(double quantia, Conta contaDestino)
  {
    Sacar(quantia);
    contaDestino.Depositar(quantia);
  }

}
