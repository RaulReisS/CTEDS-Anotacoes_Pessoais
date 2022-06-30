namespace SegundoExemploB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso = 78.1;
            double altura = 1.75;
            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"IMC é {imc}.");

            // Usamos a biblioteca Math para operações e constantes matemáticas


            // Operadores que temos é como em C, Java e etc...
            //+, -, *, / %, >, >=, <, <=, ++ , --, +=, -=, *=, /=
            // Operadores lógicos normal && e || e !
            // Não é possível usar operador de comparação com Strings. É preciso usar uma função de compare

            // Maneira rápida de ler e guardar info em variável
            int.TryParse(Console.ReadLine(), out int nota);

            // Operador ternário ( Assim como no Kotlin)

            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";

            // Controle: if, else if, else... Assim como Java e etc
            // Swtch case funciona da mesma forma que em C

            // Mesma coisa como usa o while e do while
            // Temos for e foreach, sendo o último um iterador

            // Exemplo de como usa o foreach (precisa do n para iterar)
            string palavra = "Opa!";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Os loops também permitem o uso do break e do continue

            // Usando uma Classe criada
            Pessoa siclano = new Pessoa();

            // Acessando atributos públicos da classe
            siclano.Nome = "Raul";
            siclano.Idade = 27;

            siclano.ApresentarNoConsole();

        }

        // Criando classes

        class Pessoa
        {
            public string Nome;
            public int Idade;

            public string Apresentar()
            {
                return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            }

            public void ApresentarNoConsole()
            {
                Console.WriteLine(Apresentar());
            }
        }
    }


    // Classo com construtiro não padrão
    // É Possível ter multiplos construtores (Um padrão e um não padrão)
    // É possível encadear métodos sobre um memso objeto (Kotlin também faz isso)
    class Carro
    {
        public string Modelo = "";
        public string Fabricante = "";
        public int Ano = 0;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {

        }
    }
}