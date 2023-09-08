namespace ByteBank1.View;

using ByteBank1.Model.DTO;

public class ContaView
{

  public static LoginFormDto MenuLogin()
  {
    Console.Write("Cpf: ");
    string cpf = Console.ReadLine();
    Console.Write("Senha: ");
    string password = Console.ReadLine();
    // string pass = Console.ReadKey();
    return new LoginFormDto
    {
      Cpf = cpf,
      Password = password,
      Moment = DateTime.Now
    };
  }

}