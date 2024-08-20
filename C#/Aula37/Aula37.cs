using System;

class Base
{
    public Base()
    {
        Console.WriteLine("\nConstrutor da classe Base\n");
    }   
}

class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada1\n");
    }   
}

class Derivada2:Derivada1
{
    public string nome;
    public Derivada2(string nome)
    {
        this.nome=nome;
        Console.WriteLine("Construtor da classe Derivada2\n");
    }   
}

class Aula37
{
    static void Main()
    {
        Derivada2 derivada2=new Derivada2("Robervaldo");
        Console.WriteLine("Nome da derivada 2: {0}",derivada2.nome);
    }
}