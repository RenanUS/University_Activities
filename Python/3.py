print("Digite a distância a ser percorrida em KM")
Dist = float(input())
print("Agora digite a velocidade media em KM/H")
VM = float(input())
Tempo = Dist / VM
TempoTotal = (Dist / VM) * 3600
if Tempo < 1:
    TempoM = int((Tempo) * 60)
    print("O tempo que deverá ser gasto no percurso é de",TempoM,"minutos")
elif Tempo == 1:
    print("O tempo que deverá ser gasto no percurso é de 1 hora")
elif Tempo > 1:
    TempoH = int(Dist // VM)
    TempoMinTotal = int(((Dist / VM) - (Dist // VM))*60)
    TempoMin = ((Dist / VM) - (Dist // VM))*60
    TempoS = int((TempoMin - TempoMinTotal)*60)
    if TempoH > 1 and TempoMinTotal == 0:
        print("O tempo que deverá ser gasto no percurso é de",TempoH,"horas.")
    elif TempoMinTotal > 1 and TempoS == 0:
        if TempoH == 1:
            print("O tempo que deverá ser gasto no percurso é de",TempoH,"hora e",TempoMinTotal,"minutos.")
        elif TempoH > 1:
            print("O tempo que deverá ser gasto no percurso é de",TempoH,"horas e",TempoMinTotal,"minutos.")
    elif TempoS > 1:
        if TempoH == 1:
            print("O tempo que deverá ser gasto no percurso é de",TempoH,"hora e",TempoMinTotal,"minutos e",TempoS,"segundos.")
        elif TempoH > 1:
            print("O tempo que deverá ser gasto no percurso é de",TempoH,"horas,",TempoMinTotal,"minutos e",TempoS,"segundos.")



import math
print("Indique o primeiro lado do triângulo.")
S1 = int(input())
print("Indique o segundo lado do triângulo.")
S2 = int(input())
print("Indique o terceiro lado do triângulo.")
S3 = int(input())
T = (S1 + S2 + S3)/2
AT = (math.sqrt((T*(T-S1))*(T*(T-S2))*(T*(T-S3))))
print("A área do triângulo é:",AT)



print("Indique o valor da conta.")
Conta = int(input())
print("Agora indique o valor do pagamento.")
Pagamento = int(input())
Troco = Pagamento - Conta
CedulasCem = Troco // 100
RestoCem = Troco % 100
CedulasCinquenta = RestoCem // 50
RestoCinquenta = RestoCem % 50
CedulasVinte = RestoCinquenta // 20
RestoVinte = RestoCinquenta % 20
CedulasDez = RestoVinte // 10
RestoDez = RestoVinte % 10
CedulasCinco = RestoDez // 5
RestoCinco = RestoDez % 5
CedulasDois = RestoCinco // 2
RestoDois = RestoCinco % 2
CedulaUm = RestoDois // 1
print(CedulasCem," nota(s) de cem")
print(CedulasCinquenta," nota(s) de cinquenta")
print(CedulasVinte," nota(s) de vinte")
print(CedulasDez," nota(s) de dez")
print(CedulasCinco," nota(s) de cinco")
print(CedulasDois," nota(s) de dois")
print(CedulaUm," nota(s) de um")