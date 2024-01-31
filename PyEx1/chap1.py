import math
#x: x = input(f"x {y}")
#Exercicio 1
def HelloWorld():
    return "Hello World!"

#Exercicio 2
def ImprimeNum():
    num = input("Introduza um número:")
    return f" O número informado foi {num}"

#Exercicio 3
def Soma():
    num1  = float(input("Introduza o primeiro número: "))
    num2 = float(input("Introduza o segundo número: "))
    return f"A Soma dos números é {num1 + num2}"

#Exercicio 4
def Media():
    numDeValores = int(input(f"Introduza o número de valores que quer fazer a média: "))
    valores = []

    for i in range(numDeValores):
        valores.append(float(input(f"Introduza o {i+1}º valor: ")))
    
    totalVal = 0
    media = 0

    for num in valores:
        totalVal += num

    media = totalVal/ numDeValores

    return f"A Média dos números é {media}"

#Exercicio 5
def MetrosParaCentímetros():
    metros = input("Introduz a quantidade de metros:")
    return f"O número de metros que introduziu equivale a {metros*100} centímetros."

#Exercicio 6
def AreaCirculo():
    raio = float(input("Introduza o raio do circulo:"))
    return f"A área do círculo é de {raio*raio*3.14}"

#Exercicio 7
def AreaDobroQuadrado():
    ladoTamanho = float(input("Introduza o tamanho dos lados:"))
    return f"A área do quadrado é: {ladoTamanho*ladoTamanho}, e o dobro disso é: {ladoTamanho*ladoTamanho*2}"

#Exercicio 8
def CalculeSalario():
    salario = float(input("Introduza quanto recebe por hora:"))
    numHoras = int(input("Introduza o número de horas que trabalhou neste mês:"))
    return f"Neste mês você recebeu {salario*numHoras}"

#Excercicio 9
def FahrenheitParaCelsius():
    fahrenheit = float(input("Introduza o número de graus em Fahrenheit:"))
    return f"A conversão do valor em graus que introduziu é {(fahrenheit-32) * 5/9}"

#Excercicio 10
def CelsiusParaFahrenheit():
    celsius = float(input("Introduza o número de graus em Celsius:"))
    return f"A conversão do valor em graus que introduziu é {(celsius*9/5) + 32}"

#Excercicio 11
def DoisIntUmReal():
    int1 = int(input("Introduza o primeiro número inteiro:"))
    int2 = int(input("Introduza o segundo número inteiro:"))
    float1 = int(input("Introduza o numero real:"))

    return f"O produto do dobro do primeiro com metade do segundo é {(int1*2)*(int2/2)}\nA soma do triplo do primeiro com o terceiro {(int1*3)+(float1)}\nO terceiro elevado ao cubo {float1*float1*float1}"

#Excercicio 12
def PesoIdeal():
    altura = float(input("Introduza a altura em metros:"))
    return f"O peso ideal é {(72.2*altura) - 58}"

#Excercicio 13
def PesoIdeal2():
    altura = float(input("Introduza a altura em metros:"))
    isMale = str(input("És um homem?(true/false):"))

    if isMale == "true":
        return f"O peso ideal é {(72.2*altura) - 58}"
    else:
        return f"O peso ideal é {(62.1*altura) - 44.7}"

#Exercicio 14
def CalculeMulta():
    quilos = float(input("Introduza o número de quilos pescados:"))
    return f"A multa a pagar é de {(quilos-50)*4 if quilos > 50 else 0}"

#Exercicio 15
def CalculeSalario2():
    salario = float(input("Introduza quanto recebe por hora:"))
    numHoras = int(input("Introduza o número de horas que trabalhou neste mês:"))
    salarioBruto = salario * numHoras
    renda = salarioBruto * 0.11
    inss = salarioBruto * 0.08
    sindicato = salarioBruto * 0.05
    return f"+ Salário Bruto : {salarioBruto}€\n- IR (11%) : {renda}€\n- INSS (8%) : {inss}€\n- Sindicato ( 5%) : {sindicato}€\n= Salário Liquido : {salarioBruto - renda - inss - sindicato}€"

#Exercicio 16
def LojaTinta():
    area = float(input("Introduza o tamanho da área que pretende pintar em metros:"))
    numLatas = math.ceil(area/(3*18))
    return f"Serão necessárias {numLatas} latas de tinta com o custo total de {numLatas*80}€"

#Exercicio 17
def LojaTinta2():
    area = float(input("Introduza o tamanho da área que pretende pintar em metros:"))
    litrosNecessarios = (area/6)*1.1

    numLatas = math.ceil(litrosNecessarios/18)
    numGaloes = math.ceil(litrosNecessarios/3.6)

    numLatasMistura = round(litrosNecessarios//18)
    numGaloesMistura = math.ceil((litrosNecessarios%18)/3.6)
    return f"- Serão necessárias {numLatas} latas de tinta com o custo total de {numLatas*80}€\n- Ou serão necessárias {numGaloes} galões de tinta com o custo total de {numGaloes*25}€\n- Havendo o menor desperdicio de tinta utlizando {numLatasMistura} latas de tinta e {numGaloesMistura} galões de tinta com o custo total de {(numLatasMistura*80)+(numGaloesMistura*25)}€"

#Exercicio 18
def CalculeTempoRestante():
    tamanhoDoFicheiro = float(input("Introduza o tamanho do ficheiro que quer fazer download em MB:"))
    velocidadeNet = int(input("Introduza a sua velocidade de internet em Mbps:"))
    velocidadeEmMB = velocidadeNet * 0.125

    minutosRestantes = int(tamanhoDoFicheiro//velocidadeEmMB/60)
    segundosRestantes = int(tamanhoDoFicheiro/velocidadeEmMB%60)

    return f"O download irá demorar {minutosRestantes}:{segundosRestantes}"