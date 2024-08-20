using System;

class Veiculo//Base
{
    public int VelAtual;
    private int VelMax;
    protected bool Ligado;
    public Veiculo(int VelMax)
    {
        VelAtual=0;
        this.VelMax=VelMax;
        Ligado=false;
    }
    public string getLigado()
    {
        return (Ligado?"Sim":"Não");;
    }
    public int getVelMax()
    {
        return VelMax;
    }
}
class Carro:Veiculo//Derivada de veiculo
{
    public string nome;
    public Carro(string nome, int VM):base(VM)
    {
        this.nome=nome;
        Ligado=true;
    }
}

class Aula36
{
    static void Main()
    {
        Carro carro=new Carro("Bonitão", 120);

        Console.WriteLine("Nome......: {0}",carro.nome);
        Console.WriteLine("Vel.Máxima: {0}",carro.getVelMax());
        Console.WriteLine("Ligado....: {0}",carro.getLigado());
    }
}