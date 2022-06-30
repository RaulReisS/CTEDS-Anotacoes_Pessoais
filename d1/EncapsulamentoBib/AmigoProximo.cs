using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoBib
{
    public class AmigoProximo
    {
        public readonly Subcelebridade amiga = new Subcelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo");

            Console.WriteLine(amiga.InfoPublica); // public
            // Console.WriteLine(amiga.CorDosOlhos); // protected (herança)
            Console.WriteLine(amiga.NumeroCelular); // internal (Somente o que estiver implementado no mesmo projeto)
            Console.WriteLine(amiga.JeitoDeFalar); // protected internal (Heranca ou mesmo projeto)
            // Console.WriteLine(amiga.SegredoFamilia); // private protected (Na mesma classe ou herança no memso projeto) 
            // Console.WriteLine(amiga.UsaMuitoPhotoshop); // private (Só acessado na mesma classe)
        }
    }
}
