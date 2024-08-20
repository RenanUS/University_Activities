using System;
class Aula12
{
    static void Main()
    {
        //SE(E_L){}
        //10 < 5 = false
        //10 > 5 = true
        // > < >= <= == !=

        int n1,n2,n3,n4,res;
        n1=n2=n3=n4=res=0;
        string resultado="Reprovado";

        Console.Write("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());
        
        Console.Write("Digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        Console.WriteLine("\nSua nota é: {0}\n",res);

        if(res >= 60)
        {
            resultado="Aprovado";
        }

        Console.WriteLine("Resultado: {0}", resultado);
    }
}