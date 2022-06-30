namespace Aula3
{

    class Params
    {
        // Método com múltiplos parâmetros (Do mesmo tipo)
        public static void Recepcao(params string[] nomes)
        {
            foreach(var nome in nomes)
            {
                Console.WriteLine($"Olá {nome}");
            }
        }
    }

    class ParametrosNomeados
    {
        // Utilizando parâmetros nomeados. Eu posso mudar a ordem
        public static void Formatar ( int dia, int mes, int ano)
        {
            Console.WriteLine("{0D:2}/{1:D2}/{2}", dia, mes, ano);
        }
    }

    // Criando Getters e Setters
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo, Cilindrada = cilindrada;
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Params.Recepcao("Pedro", "Luiz", "Leonardo");

            ParametrosNomeados.Formatar(mes: 7, ano: 1995, dia: 07);

            var moto1 = new Moto("Kawasaki", "Ninja", 670);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("Titan");
            moto2.SetCilindrada(150);
        }
    }

}