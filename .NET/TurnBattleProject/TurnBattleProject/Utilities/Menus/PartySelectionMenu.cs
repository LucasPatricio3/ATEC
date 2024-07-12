using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBattleProject.Utilities.Menus
{
    public class PartySelectionMenu : Menu
    {
        public PartySelectionMenu(int screenCellWidth, int screenCellHeight) : base(screenCellWidth, screenCellHeight){
            var SelectPartyButton = AddMenuItem<PixelImageButon>(new Vector2i(16, 28), new Vector2i(16, 4));
            SelectPartyButton.MapBitmaps(
                Properties.Resources.SelectPartyButton,
                Properties.Resources.SelectPartyHover,
                Properties.Resources.SelectPartyPress);
        }
    }
}
