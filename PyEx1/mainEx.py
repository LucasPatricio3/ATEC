import os
import chap1 as c1
import chap2 as c2

functionDictionary = {
    #Capitulo 1
    "1/1" : c1.HelloWorld,
    "1/2" : c1.ImprimeNum,
    "1/3" : c1.Soma,
    "1/4" : c1.Media,
    "1/5" : c1.MetrosParaCentímetros,
    "1/6" : c1.AreaCirculo,
    "1/7" : c1.AreaDobroQuadrado,
    "1/8" : c1.CalculeSalario,
    "1/9" : c1.FahrenheitParaCelsius,
    "1/10" : c1.CelsiusParaFahrenheit,
    "1/11" : c1.DoisIntUmReal,
    "1/12" : c1.PesoIdeal,
    "1/13" : c1.PesoIdeal2,
    "1/14" : c1.CalculeMulta,
    "1/15" : c1.CalculeSalario2,
    "1/16" : c1.LojaTinta,
    "1/17" : c1.LojaTinta2,
    "1/18" : c1.CalculeTempoRestante,
    #Capitulo 2
    "2/1" : c2.MaiorNum,
    "2/2" : c2.SinalDoNum,
    "2/3" : c2.Sexo,
    "2/4" : c2.isVogal,
    "2/5" : c2.MediaAprova,

}

def main():
    while True:
        os.system('cls')
        capNum = int(input("Digite o número do capítulo:"))
        exNum = int(input("Digite o número do exercício:"))

        if functionDictionary.__contains__(f"{capNum}/{exNum}"):
            print("\n" + functionDictionary[f"{capNum}/{exNum}"]())
        else: 
            print("\nO capitulo ou exercício que introduziu não existe.")

        input("\nPrima qualquer tecla para continuar.")

main()


