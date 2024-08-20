using System;
using System.Collections.Generic;
class Aula56
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");//Início

        transp.AddLast("Bicicleta");//Fim

        LinkedListNode<string>no;
        no=transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete");//Após

        no=transp.FindLast("Carro");//Antes
        transp.AddBefore(no,"Patins");

        //transp.Clear();
        
        if(transp.Find("Carro")==null)
        {
            Console.WriteLine("Não encontrado\n");
        }
        else
        {
            Console.WriteLine("Elemento encontrado\n");
        }

        //transp.Remove("Navio");
        transp.RemoveFirst();//Remove primeiro
        transp.RemoveLast();//Remove último

        foreach(string t in transp)
        {
            Console.WriteLine("Transporte: {0}",t);
        }
    }
}