def Vitoria(A, B):
    if A > B:
        print("A ganhou")
    else:
        print("B ganhou")
    return Vitoria


Rodando = True

while Rodando == True:
    print("Você deseja ver o resultado de A ou de B?")
    Opç = str(input())
    if Opç == "A" or Opç == "a":
        print("Digite o placar do time A")
        TimeA = int(input())
        print("Agora digite o placar do time B")
        TimeB = int(input())
        Vitoria(TimeA, TimeB)
    elif Opç == "B" or Opç == "b":
        print("Digite o placar do time B")
        TimeB = int(input())
        print("Agora digite o placar do time A")
        TimeA = int(input())
        Vitoria(TimeA, TimeB)
    if (Opç == "A" or Opç == "a" or Opç == "B" or Opç == "b"):
        Resposta = "0"
        while (Resposta != "S" and Resposta != "s") and (Resposta != "N" and Resposta != "n"):
            print("Você deseja ver outro resultado?")
            Resposta = str(input())
            if Resposta == "N" or Resposta == "n":
                print("Programa encerrado!")
                Rodando = False
            elif Resposta != "S" and Resposta != "s":
                print("Resposta invalida, digite um valido")
    else:
        print("Valor invalido, digite outro")
