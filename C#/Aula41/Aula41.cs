using System;

class Carro
{
    private int VelMax;

    public int vm
    {
        get
        {
            return VelMax;
        }
        set
        {
            if(value < 0)
            {
                VelMax=0;
            }
            else if(value > 300)
            {
                VelMax=300;
            }
            else
            {
                VelMax=value;
            }
        }
    }
    public Carro()
    {
        VelMax=120;
    }
}

class Aula41
{
    static void Main()
    {
        Carro c1=new Carro();

        Console.WriteLine("Velocidade:{0}",c1.vm);
    }
}
