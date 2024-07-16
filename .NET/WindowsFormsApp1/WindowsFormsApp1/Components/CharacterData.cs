using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Components
{
    public class CharacterData : GameComponent
    {
        public string name;
        public CharacterClass characterClass;

        public void GenerateCharacter()
        {
            name = "Joaquim";
            characterClass = (CharacterClass)Game.random.Next(3);
        }

        public Bitmap GetClassIcon()
        {
            switch (characterClass)
            {
                case CharacterClass.Warrior:
                    return Resources.warriorIcon;
                case CharacterClass.Mage:
                    return Resources.mageIcon;
                case CharacterClass.Priest:
                    return Resources.priestIcon;
            }
            return Resources.MissingTextureBlock;
        }

    }

    public enum CharacterClass
    {
        Warrior,
        Mage,
        Priest,
    }
}
