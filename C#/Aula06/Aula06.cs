using System;
class Aula06
{
    static void Main()
    {
        // \t=espaçamento \n=quebra linha
        double ValorCompra=5.50;
        double ValorVenda;
        double Lucro=0.1;
        string Produto="Pastel";

        ValorVenda=ValorCompra+(ValorCompra*Lucro);

        Console.WriteLine("Produto......:{0,15}",Produto);
        Console.WriteLine("Val.Compra...:{0,15:c}",ValorCompra);
        Console.WriteLine("Lucro........:{0,15:p}",Lucro);
        Console.WriteLine("Val.Venda....:{0,15:c}",ValorVenda);
    }
}