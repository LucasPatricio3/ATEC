using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Components;

namespace TurnBasedBattlerProject.Utilities
{
    public class BattleSys
    {
        private int currentPlayer;
        private bool isBattleFinished = false;

        ImageButon skill1Button;
        ImageButon skill2Button;
        ImageButon skill3Button;

        GameObject[] playerCharacters;

        public BattleSys(ImageButon skill1Button, ImageButon skill2Button, ImageButon skill3Button, GameObject[] playerCharacters, GameObject[] enemies) {
            this.skill1Button = skill1Button;
            this.skill2Button = skill2Button;
            this.skill3Button = skill3Button;

            this.playerCharacters = playerCharacters;

            playerCharacters[currentPlayer].GetComponent<CharacterData>().DisplaySkills(skill1Button, skill2Button, skill3Button);

            skill1Button.Click += (s, e) => {
                EndTurn();
            };
        }

        public void EndTurn()
        {
            currentPlayer++;
            playerCharacters[currentPlayer].GetComponent<CharacterData>().DisplaySkills(skill1Button, skill2Button, skill3Button);

        }
    }
}
