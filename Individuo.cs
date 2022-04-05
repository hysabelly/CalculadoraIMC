//classe individuo com calculos de peso, altura e nome

public class Individuo
{
    public string Nome {get => return nome;}

    public double Peso {get => return peso;}
  
    public double Altura {get => return altura;}

    public double imc {get => Math.Round(Peso/(Altura*Altura),2);}

    public Individuo(string nome, double altura, double peso)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }

}