import os
import codecs

class Screen:
    screenID = ""
    screenText = ""
    
    def __init__(self, ID:str, pathFile:str):
        self.screenID = ID
        file = codecs.open(pathFile, 'r', encoding='UTF-8')
        self.screenText = file.read()
        file.close()

def DisplayScreen(screen:Screen):
    os.system('cls')
    print(screen.screenText)