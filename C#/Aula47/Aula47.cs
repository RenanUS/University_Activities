using System;

class Calc
{
    public int Soma(params int[]n)
    {
        int s=0;
        for(int i=0;i<n.Length;i++)
        {
            s+=n[i];
        }
        return s;
    }

    public double Soma(params double[]n)
    {
        double s=0;
        for(int i=0;i<n.Length;i++)
        {
            s+=n[i];
        }
        return s;
    }
}
class Aula47
{
    static void Main()
    {
        Calc calc=new Calc();

        var res=calc.Soma(10.5,3.2);

        Console.WriteLine(res);
    }
}