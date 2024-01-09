#x: x = input(f"x {y}")

def C1Switch(num: int):
    match num:
        case 1:
            HelloWorld()
        
        case 2:
            Soma()

        case 3:
            Media()

def HelloWorld(): #Exercicio 1
    print("Hello World!")

def Soma(): #Exercicio 2
    num1 : float = input("Introduza o primeiro número: ")
    num2 : float = input("Introduza o segundo número: ")
    print(f"A Soma dos números é {num1 + num2}")

def Media():
    valores = []
    numDeValores: int = input(f"Introduza o número de valores que quer fazer a média: ")

    for i in numDeValores:
        valores[i]: float = input(f"Introduza o {i+1}º valor: ")
    
    totalVal = 0
    media = 0

    for num in valores:
        totalVal += num

    media = totalVal/ numDeValores

    print(f"A Média dos números é {media}")


