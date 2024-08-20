print("Insira a idade da pessoa:")
idade=int(input())
if idade >=18:
    print("Essa pessoa tem",idade,"anos e é maior de idade.")
elif idade >1<18:
    print("Essa pessoa tem",idade,"anos e não é maior de idade.")
elif idade == 1:
    print("Essa pessoa tem",idade,"ano e não é maior de idade.")



print("Insira um número aleatório:")
Num=int(input())
Par=Num%2
if Par == 0:
    print("Esse número é par.")
elif Par != 0:
    print("Esse número é impar.")



print("Digite o primeiro número(M):")
Num1=int(input())
print("Digite o segundo número(N):")
Num2=int(input())
Div=Num1%Num2
if Div==0:
    print("O número M(",Num1,") é divisível por N(",Num2,").")
elif Div!=0:
    print("O número M(",Num1,") não é divisível por N(",Num2,").")



print("Digite o primeiro número:")
Num1=int(input())
print("Digite o segundo número:")
Num2=int(input())
if Num1>Num2:
    print("{0} é maior que {1}".format(Num1,Num2))
elif Num2>Num1:
    print("{0} é maior que {1}".format(Num2,Num1))
elif Num1==Num2:
    print("Os dois números são iguais!")



print("Dê um valor para A:")
A = int(input())
if A == 0:
    print("Dê um valor válido para A!")
    A = int(input())
print("Dê um valor para B:")
B = int(input())
X=-B/A
print("O valor para equação AX+B=0 é igual a:{0}".format(X))



print("Insira o seu salário mínimo:")
SalMin = int(input())
print("Insira quantas horas você trabalhou:")
Horas = int(input())
ValHT = SalMin * 0.015
SalFun = (ValHT * Horas) + SalMin
Desc = SalFun * 0.075
SalDesc = SalFun - SalFun * 0.075
if SalFun>2500:
    print("Seu salário total é de: R${0}".format(SalFun))
    print("O desconto do imposto de renda é de: R${0}".format(Desc))
    print("Seu salário total é: R${0}".format(SalDesc))
elif SalFun<=2500:
    print("Seu salário total é: R${0}".format(SalFun))



print("Insira o valor do seu carro:")
ValCar = int(input())
print("Insira o ano do seu carro:")
AnoCar = int(input())
if AnoCar < 2000:
    TaxaCar = ValCar * 0.01
    print("O valor da taxa de transferência é de: R${0}".format(TaxaCar))
elif AnoCar >= 2000:
    TaxaCar = ValCar * 0.015
    print("O valor da taxa de transferência é de: R${0}".format(TaxaCar))



print("Insira seu peso:")
Peso = float(input())
print("Insira sua altura:")
Altura = float(input())
print("Insira seu gênero:")
Gênero = str(input())
if Gênero == "Homem":
    PesoId = (72.7 * Altura) - 58
    print("O seu peso ideal é:{0}Kg".format(PesoId))
    if Peso > PesoId:
        print("O seu peso está acima do ideal para você.")
    elif Peso == PesoId:
        print("O seu peso está ideal para você.")
    elif Peso < PesoId:
        print("O seu peso está abaixo do ideal para você.")
elif Gênero == "homem":
    PesoId = (72.7 * Altura) - 58
    print("O seu peso ideal é:{0}Kg".format(PesoId))
    if Peso > PesoId:
        print("O seu peso está acima do ideal para você.")
    elif Peso == PesoId:
        print("O seu peso está ideal para você.")
    elif Peso < PesoId:
        print("O seu peso está abaixo do ideal para você.")
elif Gênero == "Mulher":
    PesoId = 62.1 * Altura - 44.7
    print("O seu peso ideal é:{0}Kg".format(PesoId))
    if Peso > PesoId:
        print("O seu peso está acima do ideal para você.")
    elif Peso == PesoId:
        print("O seu peso está ideal para você.")
    elif Peso < PesoId:
        print("O seu peso está abaixo do ideal para você.")
elif Gênero == "mulher":
    PesoId = 62.1 * Altura - 44.7
    print("O seu peso ideal é:{0}Kg".format(PesoId))
    if Peso > PesoId:
        print("O seu peso está acima do ideal para você.")
    elif Peso == PesoId:
        print("O seu peso está ideal para você.")
    elif Peso < PesoId:
        print("O seu peso está abaixo do ideal para você.")



print("Diga quantos Quilowatts foram consumidos:")
Qlw = float(input())
TarMin = 7
TaxIlPu = 3.50
if Qlw >= 10:
    TarAd = Qlw * 1.4
    ValTotal = TaxIlPu + TarAd
    print("O valor da conta de energia é: R${0}".format(ValTotal))
elif Qlw < 10:
    ValTotal = TarMin + TaxIlPu
    print("O valor da conta de energia é: R${0}".format(ValTotal))



print("Quantas horas extras você trabalhou?")
HorasExTrab = int(input())
print("Quantas horas você faltou?")
HorasFalt = int(input())
Total = HorasExTrab - (HorasFalt/3 * 2)
if Total > 40:
    print("O funcionário receberá R$200,00 de gratificação de Natal.")
elif Total > 30:
    print("O funcionário receberá R$175,00 de gratificação de Natal.")
elif Total > 20:
    print("O funcionário receberá R$150,00 de gratificação de Natal.")
elif Total > 10:
    print("O funcionário receberá R$125,00 de gratificação de Natal.")
elif Total <= 10:
    print("O funcionário receberá R$100,00 de gratificação de Natal.")