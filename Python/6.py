def Area(A, B):
    Area = A * B
    print("A area é igual a",Area,"M²")
    return Area


def Volume(A, B, C):
    Volume = A * B * C
    print("Volume é igual a",Volume,"M³")
    return Volume


Rodando = True

while Rodando == True:
    print("Você deseja fazer o calculo da área ou do volume?")
    print("A para area e V para volume")
    Opç = str(input())

    if Opç == "A" or Opç == "a":
        print("Insira o valor do lado primeiro lado do quadrado ou retângulo")
        L1 = int(input())
        print("Agora insira o valor do outro lado do quadrado ou retângulo")
        L2 = int(input())
        Area(L1,L2)

    elif Opç == "V" or Opç == "v":
        print("Insira o valor do lado primeiro lado do quadrado ou retângulo")
        L1 = int(input())
        print("Agora insira o valor do segundo lado do quadrado ou retângulo")
        L2 = int(input())
        print("Agora insira o valor do terceiro lado do quadrado ou retângulo")
        L3 = int(input())
        Volume(L1,L2,L3)

    if (Opç == "A" or Opç == "a" or Opç == "V" or Opç == "v"):
        Resposta = "0"
        while (Resposta != "S" and Resposta != "s") and (Resposta != "N" and Resposta != "n"):
            print("Voce deseja realizar mais um calculo?")
            print("S para sim e N para não")
            Resposta = str(input())
            if Resposta == "N" or Resposta == "n":
                print("Programa encerrado!")
                Rodando = False
            elif Resposta != "S" and Resposta != "s":
                print("Resposta invalida")

    else:
        print("Valor invalido, digite outro")