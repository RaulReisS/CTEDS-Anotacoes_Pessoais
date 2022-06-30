namespace EncapsulamentoBib
{ 
    public class Subcelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram";

        // Herança (protected)
        protected string CorDosOlhos = "Verde";

        // Modificador a partir do C# 9.0
        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511999999999;

        // Herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        // Mesma classe  ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla bla";

        // Private padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcesssos()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}