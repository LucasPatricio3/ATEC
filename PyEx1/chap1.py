#x: x = input(f"x {y}")

def C1Switch(num: int):
    match num:
        case 1:
            HelloWorld()
        
        case 2:
            Soma()

        case 3:
            Media()

#Exercicio 1
def HelloWorld():
    print("Hello World!")

#Exercicio 2
def ImprimeNum():
    num = input("Introduza um número:")
    print(f" O número informado foi {num}")

#Exercicio 3
def Soma():
    num1  = float(input("Introduza o primeiro número: "))
    num2 = float(input("Introduza o segundo número: "))
    print(f"A Soma dos números é {num1 + num2}")

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

    print(f"A Média dos números é {media}")

#Exercicio 5
def MetrosParaCentímetros():
    metros = input("Introduz a quantidade de metros:")
    print(f"O número de metros que introduziu equivale a {metros*100} centímetros.")

#