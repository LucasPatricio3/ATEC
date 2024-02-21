import math

#Exercicio 1
def MaiorNum():
    num1 = float(input("Introduza o primeiro número:"))
    num2 = float(input("Introduza o segundo número:"))

    return f"{num1 if num1>num2 else num2} é o maior número"

#Exercicio 2
def SinalDoNum():
    num = float(input("Introduza um número"))

    return f"O número introduzido é {"Positivo" if num >= 0 else "Negativo"}"

#Exercicio 3
def Sexo():
    sexo = input("Introduza o seu sexo (M/F)")

    if sexo == "M":
        return "Sexo Masculino"
    elif sexo == "F":
        return "Sexo Feminino"
    else:
        return "Sexo Inválido"

#Exercicio 4    
def isVogal():
    letra = input("Introduza uma letra:")
    if letra == "a" or letra == "e" or letra == "i" or letra == "o" or letra == "u":
        return "A letra introduzida é uma vogal"
    else: return "A letra introduzida é uma consoante"

#Exercicio 5
def MediaAprova():
    nota1 = float(input("Introduza a primeira nota:"))
    nota2 = float(input("Introduza a segunda nota:"))

    media = (nota1+nota2)/2

    if media == 10: return "Aprovado com destinção"
    if media >= 7 : return f"Aprovado com uma média de {media}"
    else: return "Reprovado"

#Exercicio 6
def MaiorDeTres():
    num1 = float(input("Introduza a primeiro número: "))
    num2 = float(input("Introduza a segundo número: "))
    num3 = float(input("Introduza a terceiro número: "))

    return f"O número maior é {max(num1,num2,num3)}"

#Exercicio 7
def MaiorMenorDeTres():
    num1 = float(input("Introduza a primeiro número: "))
    num2 = float(input("Introduza a segundo número: "))
    num3 = float(input("Introduza a terceiro número: "))

    return f"O número maior é {max(num1,num2,num3)} e {min(num1,num2,num3)}"

#Exercicio 8
def MenorDeTres():
    produto1 = float(input("Introduza a primeiro produto: "))
    produto2 = float(input("Introduza a segundo produto: "))
    produto3 = float(input("Introduza a terceiro produto: "))

    return f"O produto mais barato custa {min(produto1,produto2,produto3)}"

#Exercicio9
def OrdenDecrescente():
    num1 = float(input("Introduza a primeiro número: "))
    num2 = float(input("Introduza a segundo número: "))
    num3 = float(input("Introduza a terceiro número: "))

    list = [num1, num2, num3]

    return f"{list.sort(reverse=True)}"

#Exercicio10
def EstudaHoras():
    turno = input("Em que turno estudas? M-matutino ou V-Vespertino ou N- Noturno: ")
    if turno == "M":
        return "Bom dia!"
    elif turno == "V":
        return "Boa tarde!"
    elif turno == "N":
        return "Boa noite!"
    else: return "Turno não é valido."

#Exercicio11
def SalarioAjuste():
    salario = float(input("Introduza o seu salário: "))

    salarioAjustado = 0

    if salario < 280:
        salarioAjustado = salario * 1.20

    elif salario >= 280 and salario < 700:
        salarioAjustado = salario * 1.15

    elif salario >= 700 and salario < 1500:
        salarioAjustado = salario * 1.1

    else:  salarioAjustado = salario * 1.05

    return f"-O seu salario antes do reajuste: {salario}\n-O percentual aplicado foi de: {round((salarioAjustado/salario)*100, 2)}%\n-O valor do aumento foi de: {salarioAjustado-salario}\n-O seu novo salário é: {salarioAjustado}"

#Exercicio12
def DescontoIR():
    salario = float(input("Introduza quanto recebe por hora:"))
    numHoras = int(input("Introduza o número de horas que trabalhou neste mês:"))

    salBruto = salario * numHoras
    irenda = salBruto * 0.05
    inss = salBruto * 0.1
    fgts = salBruto * 0.11
    totalDescontas = irenda + inss

    return f"Salário Bruto: {salBruto}€\n(-) IR (5%): {irenda}€\n (-) INSS ( 10%): {inss}€\nFGTS (11%): {fgts}€\nTotal de descontos: {totalDescontas}€\nSalário Liquido: {salBruto - totalDescontas}€"

#Exercicio13
def DiaSemana():
    dia = int(input("Introduza o número do dia da semana:"))

    match dia:
        case 1:
            return "Domingo"
        case 2:
            return "Segunda-Feira"
        case 3:
            return "Terça-Feira"
        case 4:
            return "Quarta-Feira"
        case 5:
            return "Quinta-Feira"
        case 6:
            return "Sexta-Feira"
        case 7:
            return "Sábado"
        