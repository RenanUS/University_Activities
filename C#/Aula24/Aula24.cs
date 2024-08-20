using System;
class Aula24
{
    static void Main()
    {
        int v1,v2,r;
        Console.WriteLine("Digite o primeiro valor");
        v1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        v2=Convert.ToInt32(Console.ReadLine());
        r=soma(v1,v2);
        Console.WriteLine("A soma de {0} com {1} é: {2}",v1,v2,r);
    }

    static int soma(int n1, int n2)
    {
        int res=n1+n2;
        return res;
    }

}