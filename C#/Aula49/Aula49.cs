using System;

class Mat
{
    public static double pi=3.14;

    public static int dobro(int n)
    {
        return n*2;
    } 
} 

class Aula49
{
    static void Main()
    {
        double Vpi=Mat.pi;
        int num=10;

        Console.WriteLine(Mat.dobro(num));
        Console.WriteLine(Vpi);
    }
}