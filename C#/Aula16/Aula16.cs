using System;
class Aula16
{
    static void Main()
    {
        int tempo=0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG > Vitória/ES");
        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus ");
        
        escolha=char.Parse(Console.ReadLine());

        switch(escolha)
        {
            case 'a':
            case 'A':
               tempo=50;
               break;
            case 'c':
            case 'C':
               tempo=480;
               break;
            case 'o':
            case 'O':
               tempo=660;
               break;
            default:
               tempo=-1;
               break;
        }   
        if(tempo<0)
        {
            Console.WriteLine("Transporte indisponível");
        }
        else
        {
            Console.WriteLine("\nO tempo de viajem para o transporte escolhido é {0}:{1} horas.", (tempo/60), (tempo%60));
        }

        Console.Write("\nVocê deseja calcular novamente?");
        Console.WriteLine("[s]Sim | [n]não");

        escolha=char.Parse(Console.ReadLine());
        if(escolha== 's' || escolha== 'S')
        {
               goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
}