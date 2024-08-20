using System;
using System.Collections.Generic;
class Aula57
{
    static void Main()
    {
        List<string>Carros=new List<string>();
        //List<string>Carros2=new List<string>();
        string[] Carros2=new string[4];

        Carros.Add("Golf");
        Carros.Add("HRV");
        Carros.Add("Focus");
        Carros.Add("Argo");

        //Carros2.AddRange(Carros);
        //Carros.Clear();
        
        if(Carros.Contains("Golf"))
        {
            Console.WriteLine("Carro encontrado\n");
        }
        else
        {
            Console.WriteLine("Carro não encontrado\n");
        }

        Carros.CopyTo(0,Carros2,0,4);
    
        foreach(string c in Carros2)
        {
            Console.WriteLine("Carro:{0}", c);
        }

        string ca="HRV";
        int pos=0;
        pos=Carros.IndexOf(ca)+1;
        Console.WriteLine("\nCarro {0} está na posição {1}",ca,pos);
    }
}