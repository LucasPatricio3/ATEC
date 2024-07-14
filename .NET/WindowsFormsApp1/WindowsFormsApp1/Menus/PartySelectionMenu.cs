using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Utilities;
using System.Drawing;

namespace TurnBasedBattlerProject.Menus
{
    public class PartySelectionMenu : Menu
    {
        public PartySelectionMenu()
        {
            var partySelectButton = AddMenuItem<ImageButon>(new PointF(0, -5), new PointF(16, 2));
            partySelectButton.MapBitmaps(
                Properties.Resources.SelectParty,
                Properties.Resources.SelectPartyHover,
                Properties.Resources.SelectPartyPress
            );

            DrawImage(Properties.Resources.Char_Base_Sheet_24x24, new PointF(0, 0), new PointF(4, 4));
            DrawImage(Properties.Resources.Char_Base_Sheet_24x24, new PointF(6, 0), new PointF(4, 4));
            DrawImage(Properties.Resources.Char_Base_Sheet_24x24, new PointF(-6, 0), new PointF(4, 4));
        }
    }
}
