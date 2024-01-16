from classTypes import *

mainScreen = Screen("MAINSCREEN", "CereusPrimitive/Screens/MainScreen.txt")
newItemScreen = Screen("NEWITEMSCREEN", "CereusPrimitive/Screens/NewItemScreen.txt")

screenDictionary = {
    mainScreen.screenID : mainScreen,
    newItemScreen.screenID : newItemScreen
}

def CommandToScreen(inputTxt:str):
    inputTxt = inputTxt.upper()
    for screen in screenDictionary:
        if inputTxt in screen:
            inputTxt = screen
    DisplayScreen(screenDictionary[inputTxt])


command = ""
DisplayScreen(screenDictionary[mainScreen.screenID])
while True:
    command = input()
    CommandToScreen(command)
