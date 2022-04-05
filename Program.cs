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

            double imc = Math.Round(peso/(altura*altura),2);


            Console.WriteLine("{0}, a sua altura é {1} e seu peso é {2}", nome, altura, peso );
            Console.WriteLine("O seu IMC é {0}", imc);

            if(imc<17.00)
            {
                Console.WriteLine("Você está muito abaixo do peso.");
            }

            else if (imc >=17.00 && imc <18.50)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }

            else if(imc>=18.50 && imc <25.00)
            {
                Console.WriteLine("Você está no peso normal.");
            }

            else if (imc >=25.00 && imc <30.00)
            {
                Console.WriteLine("Você está acima do peso.");
            }

            else if (imc >=30.00 && imc <35.00)
            {
                Console.WriteLine("Você está obeso - Obesidade Grau I");
            }
            else if (imc >=35.00 && imc <40.00)
            {
                Console.WriteLine("Você está obeso - Obesidade Grau II (severa)");
            }

            else 
            {
                Console.WriteLine("Você está obeso - Obesidade Grau III (mórbida)");
            }
            double pesoNormal = 0.00;
            if (imc < 18.50)
            {
                pesoNormal = Math.Round ((18.5 - imc), 2);
                Console.WriteLine("Para chegar ao Peso Normal, você precisa ganhar {0}kg!", pesoNormal);
            }
            else if (imc > 24.99)
            {
                pesoNormal = Math.Round ((imc - 24.99), 2);
                Console.WriteLine("Para chegar ao Peso Normal, você precisa perder {0}kg!", pesoNormal);
            }

        }
    }
}
