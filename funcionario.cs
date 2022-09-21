namespace POO{
    public abstract class Funcionario{
        private string nome;
        private double salario;

        public string GetNome(){
            return nome;
        }

        public void SetNome(string nome){
            this.nome = nome;
        }

        public double GetSalario(){
            return salario;
        }

        public void SetSalario(double salario){
            this.salario = salario;
        }

        public Funcionario(){
            this.nome = "";
            this.salario = 0;
            Console.WriteLine("Funcionario.Construtor");
        }

        public Funcionario(string nome, double salario){
            this.nome = nome;
            this.salario = salario;
            Console.WriteLine("Funcionario.Construtor");
        }

        public abstract double GetBonificacao();

        public abstract double GetPremioSemestral();

        public virtual string GetDescricao(){
            return nome + " " + salario;
        }
    
  public void SolicitarDados(){
    Console.WriteLine("digite o nome :");
     nome = Console.ReadLine();
    Console.WriteLine("digite seu salario :");
    salario = Console.ReadLine();
    

    }
}