using System;

class Area
{
    public static float Quad(float bas,float altura)
    {
        if(bas==0 || altura==0)
        {
            throw new Exception("Base ou altura não podem ser iguais a 0");
        }
        return bas*altura;
    }
}
class Aula52
{
    static void Main()
    {
        float area=0;
        
        try
        {
           area=Area.Quad(10f,0f);
           Console.WriteLine("Área do quadrado:{0}",area);
        }
        catch(Exception e)
        {
            Console.WriteLine("Erro: {0}",e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }
    }
}