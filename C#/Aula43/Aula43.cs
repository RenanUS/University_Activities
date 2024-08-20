using System;

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro:Veiculo,Combate
{
    public bool ligado;
    private int munição;
    public Carro()
    {
        setMunição(100);
    }

    public void setMunição(int qtde)
    {
        this.munição=qtde;
    }

    public void ligar()
    {
        this.ligado=true;
    }

        public void desligar()
    {
        this.ligado=false;
    }

    public void disparar()
    {

    }

    public void info()
    {

    }
}

class Aula43
{
    static void Main()
    {
        Carro c1=new Carro();
    }
}