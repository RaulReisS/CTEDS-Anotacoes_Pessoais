namespace Aula4
{

    // Heranças  (C# Não trabalha com herança multipla)
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int veolcidadeMaxima)
        {
            this.VelocidadeMaxima = veolcidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
                VelocidadeAtual = 0;
            else if (novaVelocidade > VelocidadeMaxima)
                VelocidadeAtual = VelocidadeMaxima;
            else
                VelocidadeAtual = novaVelocidade;

            return VelocidadeAtual;
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }

        // Modificador virtual faz o método rodar nas classes que forem herança (Indica que posso sobrescrever nas subclasses)
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
    }

        // Criando as classes que herdam da classe-pai Carro
        public class Uno: Carro
        {
            public Uno() : base(200)
            {

            }
        }

        public class Ferrari : Carro
        {
            public Ferrari() : base(350)
            {

            }

            // Sem o virtual/abstract não é possível fazer o overrride
            public override int Acelerar()
            {
                return AlterarVelocidade(15);
            }

            //Oculta o método da classe pai (Modifica seu corpotramento para essa sublcasse)
            public new int Frear()
            {
                return AlterarVelocidade(-15);
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uno...");
            var carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Uno...");
            var carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());



        }
    }
}