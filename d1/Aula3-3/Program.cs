namespace Aula3_3
{
    // Atributos Read-Only

    public class Cliente
    {
        private string Nome;
        private readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2022, 10, 10);

        }

      

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var novoCliente = new Cliente("Raul Reis", new DateTime(1995, 7, 5));

            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}