using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }

    public Ovo botar()
    {
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo
{
    private int numOvo;
    private string MinhaGalinha;
    public Ovo(int numOvo, string MinhaGalinha)
    {
        this.numOvo=numOvo;
        this.MinhaGalinha=MinhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.MinhaGalinha);
    }
}

class Aula46
{
    static void Main()
    {
        Galinha g1=new Galinha("Katia");
        Galinha g2=new Galinha("Karla");
        Galinha g3=new Galinha("Zirlane");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();
    }
}