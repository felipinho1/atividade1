namespace POO{

    class Program
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        
        static void Main(string[] args)
        {
            do{
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Funcionário");
                Console.WriteLine("3 - Cadastrar Conta Corrente");
                Console.WriteLine("4 - Relatorios");
                Console.WriteLine("0 - Sair");

                int operacao = int.Parse(Console.ReadLine());

                if( operacao == 1){
                    CadastrarCliente();
                } else if(operacao == 2){
                    CadastrarFuncionario();
                } else if(operacao == 3){
                    CadastrarContaCorrente();
                } else if(operacao == 4){
                    Relatorios();
                }
            } while(operacao != 0);

        }

        public static void CadastrarCliente(){
            Cliente cliente = new Cliente();
            cliente.SelecionarDados();
            listaClientes.Add(cliente);
        }

        public static void CadastrarFuncionario(){
            Funcionario Funcionario = new Funcionario();
            Funcionario.SelecionarDados();
            listaFuncionario.Add(cliente);
        }

        public static void CadastrarContaCorrente(){
            ContaCorrente ContaCorrente = new ContaCorrente();
            ContaCorrente.SelecionarDados();
            listaContaCorrente.Add(cliente);
        } 
  
        public static void Relatorios(){
            do{
                Console.Clear();
                Console.WriteLine("Menu relatorios");
                Console.WriteLine("1 - Cliente");
                Console.WriteLine("2 - Funcionário");
                Console.WriteLine("3 - Conta Corrente");
                Console.WriteLine("0 - Sair");

                int operacao = int.Parse(Console.ReadLine());

                if( operacao == 1){
                    RelatorioCliente();
                } else if(operacao == 2){
                    RelatorioFuncionario();
                } else if(operacao == 3){
                    RelatorioContaCorrente();
                }
            } while(operacao != 0);
        }

        public static void RelatorioCliente(){
            Console.Clear();
            foreach (Cliente c in listaClientes)
            {
                System.Console.WriteLine(c.Nome + " " + c.Cpf);
            }        
        }

        public static void RelatorioFuncionario(){
            Console.Clear();
            foreach (Funcionario c in listaFuncionario)
            {
                System.Console.WriteLine(c.nome + " " + c.salario);
            }        
        }
    
            public static void RelatorioContaCorrente(){
            Console.Clear();
            foreach (ContaCorrente c in listaContaCorrente)
            {
                System.Console.WriteLine(c.saldo + " " + c.Conta);
            }        
        }
    
    }
}