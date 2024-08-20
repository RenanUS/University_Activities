using System;

struct Carro
{
    public string Marca;
    public string Modelo;
    public string Cor;

    public Carro(string Marca, string Modelo, string Cor)
    {
        this.Marca=Marca;
        this.Modelo=Modelo;
        this.Cor=Cor;
    }

    public void info()
    {
        Console.WriteLine("Marca...: {0}",this.Marca);
        Console.WriteLine("Modelo..: {0}",this.Modelo);
        Console.WriteLine("Cor.....: {0}",this.Cor);
    }
}

class Aula44
{
    static void Main()
    {
        Carro c1;

        c1.Marca="Nissan";
        c1.Modelo="Kicks";
        c1.Cor="Vermelho";

        Console.WriteLine("Marca...: {0}",c1.Marca);
        Console.WriteLine("Modelo..: {0}",c1.Modelo);
        Console.WriteLine("Cor.....: {0}\n",c1.Cor);


        Carro c2=new Carro("Honda","Sivic","Preto");

        c2.info();
    }
}