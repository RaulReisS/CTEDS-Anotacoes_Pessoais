namespace Aula3_2
{
    // Outra maneira mais rápida de definir os Getters e Setters
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;

        double preco;

        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto {
            // get => preco-(desconto * preco)
            get { return preco-(desconto * preco); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                var opt = new CarroOpcional();
                opt.Nome = "Direção elétrica";

                Console.WriteLine(opt.Nome);

                Console.WriteLine(opt.Preco);
                Console.WriteLine(opt.PrecoComDesconto);
        }
    }
}