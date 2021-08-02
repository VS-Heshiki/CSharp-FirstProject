using System.Globalization;

namespace Course {
    class Cliente {
        public int NumConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Cliente(int numconta, string titular) {
            NumConta = numconta;
            Titular = titular;
        }

        public Cliente(int numconta, string titular, double saldo) : this(numconta, titular) {
            Saldo = saldo;
        }

        public void Deposito( double quantia ) {
            Saldo += quantia;
        }

        public void Saque( double quantia ) {
            Saldo -= quantia + 5.00;
        }

        public override string ToString() {
            return $"Conta {NumConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
