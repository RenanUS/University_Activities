using System;

abstract class Veiculo//Classe base abstrata
{
    protected int VelMax;
    protected int VelAtual;
    protected bool Ligado;
    public Veiculo()
    {
        Ligado=false;
        VelAtual=0;
    }
    public void setLigado(bool Ligado)
    {
        this.Ligado=Ligado;
    }
    public int getVelAtual()
    {
        return VelAtual;
    }

    abstract public void aceleração(int multi);
}

class Carro:Veiculo
{
    public Carro()
    {
        VelMax=120;
    }
    override public void aceleração(int multi)
    {
        VelAtual+=10*multi;
    }
}

class Aula39
{
    static void Main()
    {
        Carro Carro1=new Carro();
        
        Carro1.aceleração(1);
        Carro1.aceleração(-1);

        Console.WriteLine(Carro1.getVelAtual());
    }
}