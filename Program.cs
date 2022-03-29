using System;

namespace EstudoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu peso em kg:");
            float  peso= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a sua altura em metros:");
            float  altura= Convert.ToSingle (Console.ReadLine());

            double imc = peso/(altura*altura);

            Console.WriteLine("{0}, a sua altura é {1} e seu peso é {2}", nome, altura, peso );
            Console.WriteLine("O seu IMC é {0}", imc);
        }
    }
}