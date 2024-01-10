import random
import entities

class Structure:
    name = ""

class Chest(Structure): #This class represents a generic item storage container including cabinets, chests, etc.

    global prefixes 
    prefixes = "Normal", "Rare", "Cursed"

    def CreateChest(objectName:str, lootPool:str):
        chosenPrefix = random.choices(prefixes, weights=(80, 5, 5), k=1)


