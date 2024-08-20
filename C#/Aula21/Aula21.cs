using System;
class Aula21
{
    static void Main()
    {
        string senha="123";
        string senhadigitada;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhadigitada=Console.ReadLine();
            if(senhadigitada != senha)
            {
                Console.WriteLine("Senha Incorreta, tente novamente");
            }
        }while(senha != senhadigitada);
        
        Console.Clear();
        Console.WriteLine("Senha correta, seja bem-vindo!");
    }
}