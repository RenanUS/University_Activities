print("Diga um valor para o raio")
R = float(input())
Pi = 3.14
ComprimentoCirc = (2*Pi) * R
AreaCirculo = Pi*(R**2)
VolumeEsfera = (3/4*Pi) * (R**3)
print("O comprimento do circulo é:.",ComprimentoCirc)
print("A area do circulo é:",AreaCirculo)
print("O volume da esfera é:",VolumeEsfera)



print("Quantos gramas de ração o gato come por dia?")
Gramas = float(input())
print("Quantos dias ficará fora de casa?")
Dias = float(input())
QtdRaçãoG = Gramas * Dias
QtdRaçãoK = QtdRaçãoG / 1000
QtdSacos = int (QtdRaçãoK + 1)
print("Ele irá comer {0}KG durante a viagem".format(QtdRaçãoK))
print("Vai ser necessário",QtdSacos,"sacos de ração durante a viagem")



print("Diga a coordenada X do canto superior esquerdo do seu quadrado")
X1 = int(input())
print("Diga a coordenada Y do canto superior esquerdo do seu quadrado")
Y1 = int(input())
print("Agora diga a coordenada X do canto inferior direito do seu quadrado")
X2 = int(input())
print("E agora diga a coordenada y do canto inferior direito do seu quadrado")
Y2 = int(input())
RaioDoCirculo = (X2 - X1) / 2
CentroDoCirculo = (X2 - X1) / 2 , (Y2-Y1) / 2
print("O raio do circulo é:.",RaioDoCirculo)
print("O centro do circulo é:.",CentroDoCirculo)



print("Diga um valor para a variavel A")
VA = int(input())
print("Agora diga um valor para a variavel B")
VB = int(input())
print("Variavel A:",VA, "   Variavel B:",VB,".")
print("Agora, os valores serão invertidos.")
print(".")
print(".")
print(".")
print("O novo valor de A é",VB, "e o novo valor de B é",VA,".")