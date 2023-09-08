using ByteBank1.View;
using ByteBank1.Service;
using ByteBank1.Exceptions;

namespace ByteBank1
{

  public class Program
  {

    public static void Main(string[] args)
    {

      ContaService service = new ContaService();
      // new Conta {Id = 1L, Cpf = "123", Senha = "123pass"},
      // new Conta {Id = 2L, Cpf = "1234", Senha = "1234pass"}
      try
      {
        var loginForm = ContaView.MenuLogin();
        service.login(loginForm);
        service.transfer(20, "1234");
      }
      catch (PasswordNotMatchException passwordException)
      {
        Console.WriteLine(passwordException.Message);
      }

    }

  }

}