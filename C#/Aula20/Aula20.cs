using System;
class Aula19
{
    static void Main()
    {      
        int[] num=new int[11];

        int i=1;
        while(i<num.Length)
        {
            num[i]=0;
            Console.WriteLine("Vai tomar no cu {0}",i);
            i++;
        }

        Console.WriteLine("\nFim do loop");
    }
}