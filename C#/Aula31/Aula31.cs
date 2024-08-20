using System;
static public class Jogador
{
    static public int energia=100;
    static public bool vivo=true;
    static public string nome;
    static public void iniciar(string n)
    {
        energia=100;
        vivo=true;
        nome=n;
    }
    static public void info()
    {
        Console.WriteLine("Nome do jogador: {0}",nome);
        Console.WriteLine("Energia do jogador: {0}",energia);
        Console.WriteLine("Estado do jogador: {0}\n",vivo);
    }
}

class Inimigo
{
    static public bool alerta;
    public string nome;
    public Inimigo(string n)
    {
        alerta=false;
        nome=n;
    }
    public void info()
    {
        Console.WriteLine("Nome do inimigo: {0}",nome);
        Console.WriteLine("Estado de alerta: {0}\n",alerta);
        Console.WriteLine("-----------------------------------------");
    }
}

class Aula30
{
    
    static void Main()
    {
        Jogador.iniciar("Renan");
        Jogador.info();

        Inimigo i1=new Inimigo("Doido");
        Inimigo i2=new Inimigo("Maluco");
        Inimigo i3=new Inimigo("Pirado");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();
    }
}