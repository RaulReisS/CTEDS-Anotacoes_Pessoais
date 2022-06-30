namespace Aula3_4
{
    public enum Genero {Acao, Aventura, Terror, Animacao, Comedia} 
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = (int)Genero.Acao;
            Console.WriteLine(id); // -> 0

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Devolta para o futuro";
            filmeParaFamilia.GeneroDoFilme = Genero.Aventura;

            Console.WriteLine("{0} é {1}!",filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}