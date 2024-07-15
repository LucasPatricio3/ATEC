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

            //Character Card 1
            GameObject char1BackCard = AddObject("Char1BackCard", new PointF(-8, 2), new PointF(1, 1));
            SpriteRenderer char1CardRenderer = char1BackCard.AddComponent<SpriteRenderer>();
            char1CardRenderer.SetImage(Resources.PartySelectionBackCard);

            GameObject character1 = new GameObject("character1", new PointF(-8, 0), new PointF(1, 1));
            SpriteRenderer char1Renderer = character1.AddComponent<SpriteRenderer>();
            char1Renderer.SetImage(Resources.Char_Base_Sheet_24x24);
            char1BackCard.AddChild(character1);
            PlayableCharacter char1Data = character1.AddComponent<PlayableCharacter>();


            //Character Card 2
            GameObject character2 = AddObject("character2", new PointF(0, 0), new PointF(1, 1));
            SpriteRenderer char2Renderer = character2.AddComponent<SpriteRenderer>();
            char2Renderer.SetImage(Resources.Char_Base_Sheet_24x24);

            //Character Card 3
            GameObject character3 = AddObject("character3", new PointF(8, 0), new PointF(1, 1));
            SpriteRenderer char3Renderer = character3.AddComponent<SpriteRenderer>();
            char3Renderer.SetImage(Resources.Char_Base_Sheet_24x24);
        }
    }
}
