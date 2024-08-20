def Media(A,B):
    Media = (A+B)/2
    print("A media é igual a",Media)
    return Media

Rodando = True
i=0

while Rodando == True:
    print("Você deseja inserir a nota de quantos alunos?")
    Alunos = int(input())

    if Alunos > 0:
        for i in range (i+1,Alunos+1):
            print("Qual a primeira nota do aluno",i,"?")
            Nota1 = int(input())
            print("Qual a segunda nota do aluno",i,"?")
            Nota2 = int(input())
            Media(Nota1, Nota2)

    if (Alunos > 0):
        Resposta = "0"
        while (Resposta != "S" and Resposta != "s") and (Resposta != "N" and Resposta != "n"):
            print("Deseja realizar mais uma avaliacao de notas?")
            print("Apenas S para sim e N para nao")
            Resposta = str(input())
            if Resposta == "N" or Resposta == "n":
                print("Programa encerrado, obrigado!")
                Rodando = False
            elif Resposta != "S" and Resposta != "s":
                print("Resposta invalida")

    else:
        print("Valor invalido, insira outro")