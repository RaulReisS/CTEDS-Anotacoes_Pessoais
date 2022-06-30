using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoBib
{
    public class FilhoReconhecido : Subcelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido");
            Console.WriteLine(InfoPublica); // public
            Console.WriteLine(CorDosOlhos); // protected (herança)
            Console.WriteLine(NumeroCelular); // internal (Somente o que estiver implementado no mesmo projeto)
            Console.WriteLine(JeitoDeFalar); // protected internal (Heranca ou mesmo projeto)
            Console.WriteLine(SegredoFamilia); // private protected (Na mesma classe ou herança no memso projeto) 
            // Console.WriteLine(UsaMuitoPhotoshop); // private (Só acessado na mesma classe)
        }
    }
}
