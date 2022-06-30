using EncapsulamentoBib;

namespace Aula4_3
{
    // Trabalhando com encapsulamento
    public class FilhoNaoReconhecido : Subcelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido");
            Console.WriteLine(InfoPublica); // public
            Console.WriteLine(CorDosOlhos); // protected
            // Console.WriteLine(NumeroCelular); // internal (Somente o que estiver implementado no mesmo projeto)

            Console.WriteLine(JeitoDeFalar); // protected internal (Heranca ou mesmo projeto)
            // Console.WriteLine(SegredoFamilia); // private protected (Na mesma classe ou herança no memso projeto) 
            // Console.WriteLine(UsaMuitoPhotoshop); // private (Só acessado na mesma classe)
        }
    }

    public class AmigoDistante
    {
        public readonly Subcelebridade amiga = new Subcelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante");
            Console.WriteLine(amiga.InfoPublica); // public
            // Console.WriteLine(amiga.CorDosOlhos); // protected (herença)
            // Console.WriteLine(amiga.NumeroCelular); // internal (Somente o que estiver implementado no mesmo projeto)

            // Console.WriteLine(amiga.JeitoDeFalar); // protected internal (Heranca ou mesmo projeto)
            // Console.WriteLine(amiga.SegredoFamilia); // private protected (Na mesma classe ou herança no memso projeto) 
            // Console.WriteLine(amiga.UsaMuitoPhotoshop); // private (Só acessado na mesma classe)
        }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            new Subcelebridade().MeusAcesssos();
            new FilhoNaoReconhecido().MeusAcesssos();
            new AmigoProximo().MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}