using System;
class Aula10
{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main()
    {
        int ds=(int)DiasSemana.Domingo;    //DiasSemana ds = (DiasSemana)5;

        Console.WriteLine(ds);
    }
}