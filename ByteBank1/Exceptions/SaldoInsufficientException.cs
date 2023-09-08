namespace ByteBank1.Exceptions;

public class SaldoInsufficientException : ContaException
{

  public SaldoInsufficientException(string msg)
  : base(msg)
  {

  }

}