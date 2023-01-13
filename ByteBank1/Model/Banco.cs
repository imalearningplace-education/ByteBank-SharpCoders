namespace ByteBank1.Model {
    public class Banco {

        // atributo
        private List<Conta> _contas;
        private Conta? _contaLogada;

        public readonly string Agencia;

        public Banco(string agencia) {
            _contas = new List<Conta>();
            _contaLogada = null;
            Agencia = agencia;
        }

        // métodos
        public void register() {
            // TODO apresentar menu de registro
            string cpf = Console.ReadLine();
            string senha = Console.ReadLine();
            long id = _contas.Count + 1;
            _contas.Add( new Conta(id, cpf, senha) );
        }

        public void login() {
     
        }

        public void logout() {

        }

    }
}
