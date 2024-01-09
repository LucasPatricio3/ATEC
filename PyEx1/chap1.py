#x: x = input(f"x {y}")

def C1Switch(num: int):
    print(num)
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
def Soma():
    num1 : float = input("Introduza o primeiro número: ")
    num2 : float = input("Introduza o segundo número: ")
    print(f"A Soma dos números é {num1 + num2}")

#Exercicio 3
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


