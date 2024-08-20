using System;
class AAA
{
    static void Main()
{
    int T;
    T = int.Parse(Console.ReadLine());
    if(T<=10000)
    {
        for(int i=0;i<T;i++)
    {
        string Opt;
        Opt = Console.ReadLine();
        var SplitedItens = Opt.Split(' ');
        int J = 0;
        int P = 0 , Q = 0 , N = 0;
        foreach (var X in SplitedItens)
        {
            if(J==0) 
            {
                P = int.Parse(X);
            }
            else if(J==1)
            {
                Q = int.Parse(X);
            }
            else
            {
                N = int.Parse(X);
            }
            J++;
        }
        double B = (P + Math.Sqrt(P*P-4*Q))/2;
        double A = (P - Math.Sqrt(P*P-4*Q))/2;
        if(N!=0||(A!=0 && B!=0))
        {
            double Result = Math.Pow(A , N) + Math.Pow(B , N);
            Console.WriteLine ("Case {0}: {1}",i+1,Result);
        }
    }
    }
    
}
}
