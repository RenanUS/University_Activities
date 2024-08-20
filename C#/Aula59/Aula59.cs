using System;
using System.Collections.Generic;
class Aula59
{
    static void Main()
    {
        //string[] Vs={"Carro","Moto","Navio",Avião};
        Queue<string>Veiculos=new Queue<string>();

        Veiculos.Enqueue("Carro");
        Veiculos.Enqueue("Moto");
        Veiculos.Enqueue("Navio");
        Veiculos.Enqueue("Avião");

        Console.WriteLine("Digite um veiculo:");
        string V=Console.ReadLine();
        if(Veiculos.Contains(V))
        {
            Console.WriteLine("Veiculo " + V + " encontrado");
        }
        else
        {
            Console.WriteLine("Veiculo " + V + " não encontrado");
        }

        //Console.WriteLine("Primeiro veiculo: "+Veiculos.Dequeue()); Retona e remove
        //Console.WriteLine("Primeiro veiculo: "+Veiculos.Peek()); Retona e não remove
        
        //foreach(string v in Veiculos)
        //{
        //    Console.WriteLine("Veiculo "+v);
        //}
        
        Console.WriteLine("\nTamanho da fila: {0}\n",Veiculos.Count);

        while(Veiculos.Count > 0)
        {
            Console.WriteLine(Veiculos.Dequeue());
        }
        Console.WriteLine("Pertencem a fila");
    }
}