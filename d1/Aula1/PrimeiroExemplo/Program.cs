using System.Globalization;

namespace PrimeiroExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = 1.5;
            const double pi = Math.PI;

            raio = 5.5;

            // Comentário de linha

            /* Comentário 
             * em
             * bloco
             */

            bool estaChuvendo = true;


            byte idade = 27;

            sbyte saldoDeGols = sbyte.MinValue;

            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            Console.WriteLine("Raio:  " + raio);

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Max Int:" + int.MaxValue);

            Console.WriteLine("Max decimal:" + decimal.MaxValue);


            // Inferência
            var nome = "Raul";
            // nome = 123; -> Não funciona

            Console.WriteLine(nome);

            // Interpolação 
            Console.WriteLine("Nome: {0}, idade: {1}", nome, idade);

            Console.WriteLine($"Nome: {nome}, idade: {idade+1}");

            // Transformação de String
            var saudacao = "olá".ToUpper().Insert(3, " mundo");

            string valorImportante = null;

            // Lendo dados do console
            Console.WriteLine("Qual o seu nome? ");
            string name = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Com invariantCulture ele ignora a vírgula para obter o número
            //  CurrentCultire usa a lingua do sistema operacionao para o sistema de escrita
            Console.WriteLine($"{nome} {idade} {salario}");

            double salary = 250.00;

            // Definindo número de casas decimais
            Console.WriteLine(salary.ToString("F1"));

            // Exibir em padrão monetário
            Console.WriteLine(salary.ToString("C"));

            // Porcentagem
            Console.WriteLine(salary.ToString("P"));

            // Modo de exibição
            Console.WriteLine(salary.ToString("###.##"));


            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(salary.ToString("C0", culture));

            int var2 = 256;
            Console.WriteLine(salary.ToString("D10"));

        }
    }
}