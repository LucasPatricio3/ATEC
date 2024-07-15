using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Components
{
    public class PlayableCharacter : GameComponent
    {
        public string name;
        public CharacterClass characterClass;
        //public
    }

    public enum CharacterClass
    {
        Warrior,
        Mage,
        Priest,
    }
}
