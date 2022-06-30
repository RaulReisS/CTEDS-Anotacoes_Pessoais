namespace Aula3_5
{
    // Trabalhando com Struct a sua diferença para Classe
    // A classe trabalha por sistema de referência.
    // Se quiser trabalhar por referência com Struct, precisa de ponteiro
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class Cponto
    {
        public int X;
        public int Y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 6;

            Console.WriteLine($"Ponto 1: {ponto1.X}");
            Console.WriteLine($"Ponto Cópia: {copiaPonto1.X}");

            Cponto ponto2 = new Cponto { X = 1, Y = 2 };
            Cponto copiaPonto2 = ponto2;
            ponto2.X = 10;

            Console.WriteLine($"Ponto 2: {ponto2.X}");
            Console.WriteLine($"Ponto Cópia: {copiaPonto2.X}");
        }
    }
}