from dataclasses import dataclass
import os

class AgendaContactos:
    owner = ""
    listaContactos = list()

    def main(self):
        exit = False

        os.system('cls')
        if self.owner == "":
            self.owner = self.InputName()

        while(exit == False):
            os.system('cls')
            print(f"Olá {self.owner}!")
            print("1- Adicionar Contacto\n2- Ver Lista de Contactos\n3- Eliminar Contacto\n4- Sair")
            choice = input()
            print(mainMenu[choice])
            input()


    def InputName() -> str:
        name = input("Olá novo utilizador, puderia introduzir o seu nome: ")
        return name
    
    
    def AdicionarContacto():
        pass


    def ListaContactos():
        pass


    def EliminarContacto():
        pass
    

    def Exit():
        pass


@dataclass
class Morada:
    localidade: str

    def __init__(self, local: str):
        self.localidade = local


class Contacto:
    name: str
    numero: str
    notas: str
    email: str
    morada: Morada

    def __init__(self, name: str, numero: str, notas: str, morada: Morada):
        self.name = name
        self.numero = numero
        self.notas = notas
        self.morada = morada


mainMenu = {
    "1": AgendaContactos.AdicionarContacto,
    "2": AgendaContactos.ListaContactos,
    "2": AgendaContactos.EliminarContacto,
    "2": AgendaContactos.Exit,
}


