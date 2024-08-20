print("Informe o raio da base: ")
RaioBase = float(input())
print("Agora informe a altura: ")
Altura = float(input())
RaioBase2 = RaioBase**2
Pi = 3.14
AreaDaBase = RaioBase2 * Pi
AreaCilindro = 2 * Pi * RaioBase * (RaioBase+Altura)
VolumeCilindro = AreaDaBase * Altura
print("Essa é a área do Cilindro:", AreaCilindro,"M²")
print("E esse é o volume:", VolumeCilindro,"M³")


print("Informe o tempo de viagem em horas:")
TempoViagem = float(input())
print("Agora informe a velocidade média da viagem, em KM/H:")
VelMedia = float(input())
print("Quantos KMs o carro faz com 1L de combustível?")
ConsumoMedio = float(input())
DistanciaViagem = TempoViagem * VelMedia
LitrosCombus = DistanciaViagem / ConsumoMedio
print("A quantidade de combustível gasta nessa viagem foi de:{0}L".format(LitrosCombus))


print("Qual o valor do produto?")
ValorProd = float(input())
print("Quanto será o desconto, em %, aplicado?")
Desc = float(input())
PercDesc = Desc / 100
ValorDesc = ValorProd * PercDesc
ValorFinal = ValorProd - ValorDesc
print("O valor do desconto foi de R${0}".format(ValorDesc))
print("E o valor final do produto foi de R${0}".format(ValorFinal))


print("Qual o valor da conta?")
ValorConta = float(input())
print("A quantos dias essa conta está atrasada?")
DiasAtraso = int(input())
print("Qual a multa por 1 dia de atraso?")
MultaDias = float(input())
print("Qual o percentual de juros por dia de atraso?")
JurosPorDiaInt = float(input())
JurosPorDiaPorc = JurosPorDiaInt / 100
ValorTotalMulta = DiasAtraso * MultaDias
JurosPorValor = JurosPorDiaPorc * ValorConta
JurosTotais = JurosPorValor * DiasAtraso
ValorTotal = JurosTotais + ValorConta + ValorTotalMulta
print("O valor da multa por",DiasAtraso, "dias de atraso é: R${0}".format(ValorTotalMulta))
print("O valor dos juros por",DiasAtraso, "dias de atraso é: R${0}".format(JurosTotais))
print("O valor total da conta é R${0}".format(ValorTotal))



print("Qual o salário minímo?")
SalarioMin = float(input())
print("Quantas horas você trabalhou?")
NumHoras = int(input())
print("Você possui quantos dependentes?")
Dependentes = int(input())
print("Quantas horas extras você trabalhou?")
HorasExtrasTrabalhadas = int(input())
ValHoraTrab = SalarioMin / 10
SalarioMes = ValHoraTrab * NumHoras
SalarioFamilia = SalarioMin * 0.05
SalarioFamiliaTotal = SalarioFamilia * Dependentes
HoraExtraVal = ValHoraTrab * 1.5
HoraExtraTotal = HoraExtraVal * HorasExtrasTrabalhadas   
SalarioBruto = SalarioMes + SalarioFamiliaTotal + HoraExtraTotal
IRRF = SalarioBruto * 0.1
SalarioFinal = SalarioBruto - IRRF
print("Valor da hora trabalhada:R${0}".format(ValHoraTrab))
print("Valor do salário do mês:R${0}".format(SalarioMes))
print("Valor de um salário família:R${0}".format(SalarioFamilia))
print("Valor do salário família total:R${0}".format(SalarioFamiliaTotal))
print("Valor de uma hora extra trabalhada:R${0}".format(HoraExtraVal))
print("Valor do salário bruto:R${0}".format(SalarioBruto))
print("Valor do IRRF:R${0}".format(IRRF))
print("Valor do salário a receber:R${0}".format(SalarioFinal))



print("Qual o raio do cilindro?")
Raio = float(input())
print("Qual a altura do cilindro?")
Altura = float(input())
print("Quantos tanques deseja pintar?")
QuantTanques = int(input())
Pi = 3
AreaBase = Pi * (Raio**2)
AreaTanque = AreaBase * Altura
AreaTotal = AreaTanque * QuantTanques
QuantLatas = AreaTotal / 15
ValorTotal = QuantLatas * 45
print("A área total a ser pintada é de:{0}m²".format(AreaTotal))
print("Será necessária {0} lata de tinta para pintar esta área".format(QuantLatas))
print("O valor total será de R${0}".format(ValorTotal))



print("Qual a quantia que você possui em R$?")
Quantia = float(input())
print("Quanto está a cotação do Dólar?")
CotDol = float(input())
print("Quanto está a cotação do Euro?")
CotEuro = float(input())
print("Quanto está a cotação da Libra?")
CotLibra = float(input())
ValDol = Quantia // CotDol
ValEuro = Quantia // CotEuro
ValLibra = Quantia // CotLibra
print("Sua quantia em Dólar é aproximadamente US${0}".format(ValDol))
print("Sua quantia em Euro é aproximadamente €{0}".format(ValEuro))
print("Sua quantia em Libra é aproximadamente £{0}".format(ValLibra))



print("Qual foi a distância percorrida em KM?")
DistPerc = float(input())
print("Quantas horas foram necessárias?")
TempoHora = int(input())
print("Quantos minutos foram necessários?")
TempoMin = int(input())
print("E quantos segundos foram necessários?")
TempoSeg = int(input())
DistM = DistPerc * 1000
HorasSeg = TempoHora * 3600
MinSeg = TempoMin * 60
TempoTotal = HorasSeg + MinSeg + TempoSeg
VelMedia = DistM / TempoTotal
print("A sua velocidade média foi de {0}m/s".format(VelMedia))



print("Diga a coordenada x de um ponto")
PontoX = int(input())
print("Diga a coordenada y de um ponto")
PontoY = int(input())
print("Diga a largura do retângulo")
Larg = int(input())
print("Diga a altura do retângulo")
Alt = int(input())
Ponto2 = PontoX, PontoY + Alt
Ponto3 = PontoX + Larg, PontoY
Ponto4= PontoX + Larg,PontoY + Alt
print("Ponto 2 é:{0}".format(Ponto2))
print("Ponto 3 é:{0}".format(Ponto3))
print("Ponto 4 é:{0}".format(Ponto4))