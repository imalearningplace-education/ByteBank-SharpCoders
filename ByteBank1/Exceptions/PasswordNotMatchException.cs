namespace ByteBank1.Exceptions;


public class PasswordNotMatchException : ContaException
{

  public PasswordNotMatchException()
  : base("As senhas não coincidem!")
  {

  }

  public PasswordNotMatchException(string msg)
  : base(msg)
  {

  }

}