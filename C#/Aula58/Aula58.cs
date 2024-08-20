using System;
using System.Collections.Generic;
class Aula58
{
    static void Main()
    {
        List<string>Carros=new List<string>();
        //List<string>Carros2=new List<string>();
        string[] Carros2=new string[6];

        Carros.Add("Golf");
        Carros.Add("HRV");
        Carros.Add("Focus");
        Carros.Add("Argo");
        Carros.Add("HRV");

        //Carros2.AddRange(Carros);
        //Carros.Clear();
        
        if(Carros.Contains("Golf"))
        {
            Console.WriteLine("\nCarro encontrado\n");
        }
        else
        {
            Console.WriteLine("\nCarro não encontrado\n");
        }

        Carros.Insert(1,"Cruze");

        //Carros.Remove("Argo");

        //Carros.RemoveAt(0);

        //Carros.Reverse();

        //Carros.Sort();

        int Tamanho=Carros.Count;
        Carros.Capacity=15;
        int Capacidade=Carros.Capacity;

        Console.WriteLine("Tamanho da lista: {0}",Tamanho);
        Console.WriteLine("Capacidade da lista: {0}\n",Capacidade);

        Carros.CopyTo(0,Carros2,0,6);

        int pos=Carros.LastIndexOf("HRV")+1;
    
        foreach(string c in Carros2)
        {
            Console.WriteLine("Carro:{0}", c);
        }

        string ca="HRV";
        int pos2=0;
        pos2=Carros.IndexOf(ca)+1;
        Console.WriteLine("\nCarro {0} está na posição {1}",ca,pos2);
        Console.WriteLine("\nUltimo HRV está na posição {0}",pos);
    }
}