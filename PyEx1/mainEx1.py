import chap1 as c1

def main():

    capNum = int(input("Digite o número do capítulo:"))
    exNum = int(input("Digite o número do exercício:"))

    match capNum:
        case 1:
            c1.C1Switch(exNum)
main()


