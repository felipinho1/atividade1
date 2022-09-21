namespace POO.Banco{
    public class ContaCorrente{
        private Cliente titular;
        private string conta = "";
        private int numeroAgencia;
        private string nomeAgencia = "";
        private double saldo;


        public ContaCorrente(Cliente titular, string conta, int numeroAgencia, string nomeAgencia, double saldo){
            SetTitular(titular);
            SetConta(conta);
            SetNumeroAgencia(numeroAgencia);
            SetNomeAgencia(nomeAgencia);
            SetSaldo(saldo);
        }

         public Cliente GetTitular(){
            return titular;
        }

        public void SetTitular(Cliente titular){
            this.titular = titular;
        }

        public string GetConta(){
            return conta;
        }
        
        public void SetConta(string conta){
            this.conta = conta;
        }

        public int GetNumeroAgencia(){
            return numeroAgencia;
        }
        
        public void SetNumeroAgencia(int numeroAgencia){
            this.numeroAgencia = numeroAgencia;
        }
        
        public string GetNomeAgencia(){
            return nomeAgencia;
        }
        public void SetNomeAgencia(string nomeAgencia){
            this.nomeAgencia = nomeAgencia;
        }

        public double GetSaldo(){
            return saldo;
        }
        public void SetSaldo(double saldo){
            this.saldo = saldo;
        }

        public bool Depositar(double valor){
            if(valor <= 0){
                return false;
            }

            saldo = saldo + valor;
            return true;
        }

        public bool Sacar(double valor){
            if(valor <= 0 || saldo < valor){
                return false;
            }

            saldo = saldo - valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente conta){
            if(!Sacar(valor)){
                return false;
            }

            conta.Depositar(valor);

            return true;
        }

        public void DadosConta(){
            //Console.WriteLine("Titular: " + GetTitular().Nome);
            Console.WriteLine("Conta: " + GetConta());
            Console.WriteLine("Número da Agência: " + GetNumeroAgencia());
            Console.WriteLine("Nome da Agência: " + GetNomeAgencia());
            Console.WriteLine("Saldo Maria: " + GetSaldo());
        } 

        public void SolicitarDados(){
            Console.WriteLine("digite sua conta :");
             cpf = Console.ReadLine();
            Console.WriteLine("digite o numero da agencia :");
             numeroAgencia = Console.ReadLine();
            Console.WriteLine("qual o nome da agencia :");
             nomeAgencia = Console.ReadLine();
             Console.WriteLine("qual seu saldo :");
             saldo = Console.ReadLine();
        }

    }
}