import os
import chap1 as c1
import chap2 as c2
import agendaContacto as aC

#https://wiki.python.org.br/ListaDeExercicios

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
    "2/6" : c2.MaiorDeTres,
    "2/7" : c2.MaiorMenorDeTres,
    "2/8" : c2.MenorDeTres,   
    "2/9" : c2.OrdenDecrescente,      
    "2/10" : c2.EstudaHoras,
    "2/11" : c2.SalarioAjuste,
    "2/12" : c2.DescontoIR,
    "2/13" : c2.DiaSemana,
}

def main():
    while True:
        os.system('cls')
        capNum = input("Digite o número do capítulo:")
        exNum = int(input("Digite o número do exercício:"))

        if capNum.__contains__("Ex"):
            ExtraFunctions(exNum)

        if functionDictionary.__contains__(f"{capNum}/{exNum}"):
            print("\n" + functionDictionary[f"{capNum}/{exNum}"]())
        else: 
            print("\nO capitulo ou exercício que introduziu não existe.")

        input("\nPrima qualquer tecla para continuar.")

def ExtraFunctions(exNum: int):
    match exNum:
        case 1:
            contactos = aC.AgendaContactos
            contactos.main(contactos)



main()


