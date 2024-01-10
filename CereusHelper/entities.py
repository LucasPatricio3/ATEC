import math

class Entity:
    name = ""
    description = ""

class Item(Entity):
    weight = 0

class LootPool:
    name = ""
    entities = []

    def CreateLootPool(Name: str, Entities: Entity):
        name = Name
        entities = Entities