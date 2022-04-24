public class Individuo
{
    //classe individuo nome, peso, altura e cálculo de IMC.
    public string Nome {get; set;}
    public double Peso {get; set;}  
    public double Altura {get; set;}

    public Individuo()
    {
        //public Individuo com string nome, double altura e double peso.
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }
    
     public double CalculoImc()
    {
         
        double imc = Peso / (Altura * Altura);
        return Math.Round (imc, 2);
    } 

    public string FaixaAtual()
    {            
            //public string Faixa com retorno do nível onde o usuário está.
            if(imc<17.00)
            {
                return "Você está muito abaixo do peso!\n";
            }
            else if (imc >=17.00 && imc <18.50)
            {
                return "Você está abaixo do peso!\n";
            }
            else if(imc>=18.50 && imc <25.00)
            {
                return "Você está no peso normal!\n";
            }
            else if (imc >=25.00 && imc <30.00)
            {
                return "Você está acima do peso.\n";
            }
            else if (imc >=30.00 && imc <35.00)
            {
                return "Você está obeso - Obesidade Grau I\n";
            }
            else if (imc >=35.00 && imc <40.00)
            {
                return "Você está obeso - Obesidade Grau II (severa)\n";
            }
            else 
            {
                return "Você está obeso - Obesidade Grau III (mórbida)\n";
            }

            return -1;
    }

    public double PesoIdeal()
    {
        //public double com o retorno da quantidade necessária de peso pra perder ou ganhar.
        if(imc < 18.50)
        {
            double pesoNecessario = ((18.5*Peso)/imc) -Peso;
            Console.WriteLine("Para chegar ao peso ideal, você precisa ganhar:");
            return pesoNecessario;
        }

        else if(imc >= 25)
        {
            double pesoNecessario = Peso- ((24.99*Peso)/imc);
            Console.WriteLine("Para chegar ao peso ideal, você precisa perder:");
            return pesoNecessario;
        }
        
        else
        {
            PesoIdeal = CalculoImc() * (Altura * Altura);
            Console.WriteLine("Você já está no peso ideal!");
        }
        return Math.Round(PesoIdeal, 2);
    }
}
