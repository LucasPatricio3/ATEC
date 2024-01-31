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



