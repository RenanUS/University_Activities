using System;

struct Carro
{
    public string Modelo;
    public string Cor;

    public void info()
    {
        Console.WriteLine("Modelo..: {0}",this.Modelo);
        Console.WriteLine("Cor.....: {0}",this.Cor);
        Console.WriteLine("-----------------");
    }
}

class Aula44
{
    static void Main()
    {
        int[] números=new int[10];

        Carro[] carros=new Carro[4];

        carros[0].Modelo="HRV";
        carros[0].Cor="Prata";

        carros[1].Modelo="Golf";
        carros[1].Cor="Azul";

        carros[2].Modelo="Jetta";
        carros[2].Cor="Branco";

        carros[3].Modelo="Argo";
        carros[3].Cor="Preto";

        for(int i=0; i<carros.Length; i++)
        {
            carros[i].info();
        }
    }
}