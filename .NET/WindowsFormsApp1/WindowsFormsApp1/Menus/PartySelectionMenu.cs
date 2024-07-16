using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Utilities;
using System.Drawing;
using TurnBasedBattlerProject.Components;
using TurnBasedBattlerProject.Properties;
using System.Windows.Forms;
using System.Diagnostics;

namespace TurnBasedBattlerProject.Menus
{
    public class PartySelectionMenu : GameMenu
    {
        public PartySelectionMenu()
        {
            ImageButon partySelectButton = AddMenuItem<ImageButon>(new PointF(0, -5), new PointF(16, 2));
            partySelectButton.MapBitmaps(
                Resources.SelectParty,
                Resources.SelectPartyHover,
                Resources.SelectPartyPress
            );

            ImageButon refreshPartyButton = AddMenuItem<ImageButon>(new PointF(-9.5f, -5), new PointF(2, 2));
            refreshPartyButton.MapBitmaps(
                Resources.RefreshButton,
                Resources.RefreshButtonHover,
                Resources.RefreshButtonPress
            );

            //Character Card 1
            GameObject char1BackCard = AddObject("Char1BackCard", new PointF(-8, 2), new PointF(1, 1));
            char1BackCard.AddComponent<SpriteRenderer>();
            char1BackCard.GetComponent<SpriteRenderer>().image = Resources.PartySelectionBackCard;

            GameObject character1 = new GameObject("character1", new PointF(-8, 0), new PointF(1, 1));
            character1.AddComponent<SpriteRenderer>();
            character1.GetComponent<SpriteRenderer>().image = Resources.Char_Base_Sheet_24x24;
            CharacterData char1Data = character1.AddComponent<CharacterData>();
            char1Data.GenerateCharacter();
            char1BackCard.AddChild(character1);

            GameObject char1Icon = AddObject("char1Icon", new PointF(-10, 5.5f), new PointF(1, 1));
            SpriteRenderer char1IconRend = char1Icon.AddComponent<SpriteRenderer>();
            char1IconRend.image = char1Data.GetClassIcon();
            char1BackCard.AddChild(char1Icon);


            //Character Card 2
            GameObject char2BackCard = AddObject("Char2BackCard", new PointF(0, 2), new PointF(1, 1));
            char2BackCard.AddComponent<SpriteRenderer>();
            char2BackCard.GetComponent<SpriteRenderer>().image = Resources.PartySelectionBackCard;

            GameObject character2 = new GameObject("character2", new PointF(0, 0), new PointF(1, 1));
            character2.AddComponent<SpriteRenderer>();
            character2.GetComponent<SpriteRenderer>().image = Resources.Char_Base_Sheet_24x24;
            CharacterData char2Data = character2.AddComponent<CharacterData>();
            char2Data.GenerateCharacter();
            char2BackCard.AddChild(character2);

            GameObject char2Icon = AddObject("char2Icon", new PointF(-2, 5.5f), new PointF(1, 1));
            SpriteRenderer char2IconRend = char2Icon.AddComponent<SpriteRenderer>();
            char2IconRend.image = char2Data.GetClassIcon();
            char2BackCard.AddChild(char2Icon);


            //Character Card 2
            GameObject char3BackCard = AddObject("Char3BackCard", new PointF(8, 2), new PointF(1, 1));
            char3BackCard.AddComponent<SpriteRenderer>();
            char3BackCard.GetComponent<SpriteRenderer>().image = Resources.PartySelectionBackCard;

            GameObject character3 = new GameObject("character3", new PointF(8, 0), new PointF(1, 1));
            character3.AddComponent<SpriteRenderer>();
            character3.GetComponent<SpriteRenderer>().image = Resources.Char_Base_Sheet_24x24;
            CharacterData char3Data = character3.AddComponent<CharacterData>();
            char3Data.GenerateCharacter();
            char3BackCard.AddChild(character3);

            GameObject char3Icon = AddObject("char3Icon", new PointF(6, 5.5f), new PointF(1, 1));
            SpriteRenderer char3IconRend = char3Icon.AddComponent<SpriteRenderer>();
            char3IconRend.image = char3Data.GetClassIcon();
            char3BackCard.AddChild(char3Icon);


            refreshPartyButton.Click += (s, e) => 
            {
                char1Data.GenerateCharacter();
                char2Data.GenerateCharacter();
                char3Data.GenerateCharacter();
                Debug.WriteLine(char3IconRend.image);
                Game.instance.Refresh();
            };

            partySelectButton.Click += (s, e) =>
            {
                char1BackCard.MoveTo(new PointF(-8, 5));
            };
        }
    }
}
