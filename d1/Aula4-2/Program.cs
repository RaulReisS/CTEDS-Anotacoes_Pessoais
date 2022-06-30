namespace Aula4_2
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public  Cachorro(string nome): base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) { 
            Altura = altura;
        }

        // Método que converte a classe em uma string. Toda classe tem.
        public override string ToString()
        {
            return $"{Name} tem {Altura} cm de altura!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}