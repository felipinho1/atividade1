namespace POO{
    public class Cliente{
        private string cpf = "";
        public string Nome{ get; set; }
        public string Profissao{ get; set; }

        public static int QtdClientes{ get; set; }

        public string Cpf{
            get{
                return cpf;
            }
            private set{
                this.cpf = value;
            }
        }

        public Cliente(string cpf){
            this.cpf = cpf;
            this.Nome = "";
            this.Profissao = "";
            QtdClientes ++;
        }

        public Cliente(string cpf, string nome){
            this.cpf = cpf;
            this.Nome = nome;
            this.Profissao = "";
            QtdClientes ++;
        }
        
        public void SolicitarDados(){
            System.Console.WriteLine("Nome: ");
            cpf = Console.ReadLine();
            System.Console.WriteLine("CPF: ");
            Nome = Console.ReadLine();
            System.Console.WriteLine("Profissao: ");
            Profissao = Console.ReadLine();
        }
    }
}