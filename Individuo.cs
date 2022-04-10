public class Individuo
{
    //classe individuo nome, peso, altura e cálculo de IMC.
    public string Nome {get; set;}
    public double Peso {get; set;}  
    public double Altura {get; set;}
    public double imc {get => Math.Round(Peso/(Altura*Altura),2);}

    public Individuo(string nome, double altura, double peso)
    {
        //public Individuo com string nome, double altura e double peso.
        this.Nome = nome;
        this.Peso = peso;
        this.Altura = altura;
    }
    
    /*
    public void setNome(string nome) 
    {
        this.Nome = nome;
    }

    public void setAltura(double altura) 
    {
        this.Altura = altura;
    }

    public void setPeso(double peso) 
    {
        this.Peso = peso;
    } 
    */

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
        return "Você já está no peso ideal!";
    }
}
