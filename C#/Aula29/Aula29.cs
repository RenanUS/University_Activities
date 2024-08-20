using System;
public class Jogador
{
    public int energia=100;
    public bool vivo=true;
    public string nome;
    public Jogador(string n)
    {
        energia=100;
        vivo=true;
        nome=n;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador {0} foi deletado",nome);
    }
}
class Aula29
{
    static void Main()
    {
        string nome1;
        string nome2;
        string nome3;
        Console.WriteLine("Digite o nome do jogador 1");
        nome1=Console.ReadLine();
        Console.WriteLine("Digite o nome do jogador 2");
        nome2=Console.ReadLine();
        Console.WriteLine("Digite o nome do jogador 3");
        nome3=Console.ReadLine();

        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador(nome2);
        Jogador j3=new Jogador(nome3);

        Console.WriteLine("Energia do jogador 1({0}): {1}",j1.nome, j1.energia);
        Console.WriteLine("Energia do jogador 2({0}): {1}",j2.nome, j2.energia);
        Console.WriteLine("Energia do jogador 3({0}): {1}",j3.nome, j3.energia);
    }
}