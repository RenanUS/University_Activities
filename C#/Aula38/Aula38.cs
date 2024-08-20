using System;

class Base
{
    public Base()
    {
        Console.WriteLine("\nConstrutor da classe Base\n");
    }   
    virtual public void info(){}
}

class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada1\n");
    }   
    override public void info()
    {
        Console.WriteLine("Derivada 1\n");
    }
}

class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada2\n");
    }
    override public void info()
    {
        Console.WriteLine("Derivada 2\n");
    }   
}

class Aula37
{
    static void Main()
    {
        Base Ref;
        Derivada1 derivada1=new Derivada1();
        Derivada2 derivada2=new Derivada2();
        
        Ref=derivada2;
        Ref.info();
    }
}