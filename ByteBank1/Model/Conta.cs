namespace ByteBank1.Model {
    public class Conta {

        // get - visualização
        // set - alteração

        // atributos
        public long Id { get; private set; }
        public string Cpf { get; private set; } = null!;
        public string Senha { get; private set; } = null!;
        public double Saldo { get; private set; }
        public bool EstaBloqueada { get; protected set; }

        // construtor
        public Conta(long id, string cpf, string senha) {
            Id = id;
            Cpf = cpf;
            Senha = senha;
            Saldo = 0.0;
            EstaBloqueada = false;
        }

        // métodos
        public bool Depositar(double quantia) {
            if (EstaBloqueada) 
                return false;

            Saldo += quantia;
            return true;
        }

        public bool Sacar(double quantia) {
            // validação 1
            if (EstaBloqueada)
                return false;

            // validação 2
            if (Saldo < quantia)
                return false;

            Saldo -= quantia;
            return true;
        }

        public bool Transferir(double quantia, Conta contaDestino) {
            if (contaDestino.EstaBloqueada)
                return false;

            if (!Sacar(quantia))
                return false;

            return contaDestino.Depositar(quantia);
        }

    }
}
