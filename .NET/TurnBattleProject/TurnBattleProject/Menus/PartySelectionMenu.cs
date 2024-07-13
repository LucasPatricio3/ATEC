using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBattleProject.Utilities;

namespace TurnBattleProject.Menus
{
    public class PartySelectionMenu : Menu
    {
        public PartySelectionMenu(int screenCellWidth, int screenCellHeight) : base(screenCellWidth, screenCellHeight)
        {
            var SelectPartyButton = AddMenuItem<PixelImageButon>(new Vector2i(16, 28), new Vector2i(16, 4));
            SelectPartyButton.MapBitmaps(
                Properties.Resources.SelectPartyButton,
                Properties.Resources.SelectPartyHover,
                Properties.Resources.SelectPartyPress);

            var Character1 = AddMenuItem<PixelImage>(new Vector2i(6, 18), new Vector2i(4, 8));
            Character1.SetImage(Properties.Resources.Char_Base);
            var Character1Panel = AddMenuItem<PictureBox>(new Vector2i(6, 14), new Vector2i(8, 20));
            Character1Panel.BackColor = Color.Red;

            var Character2 = AddMenuItem<PixelImage>(new Vector2i(16, 18), new Vector2i(4, 8));
            Character2.SetImage(Properties.Resources.Char_Base);
            var Character2Panel = AddMenuItem<PictureBox>(new Vector2i(16, 14), new Vector2i(8, 20));
            Character2Panel.BackColor = Color.Red;

            var Character3 = AddMenuItem<PixelImage>(new Vector2i(26, 18), new Vector2i(4, 8));
            Character3.SetImage(Properties.Resources.Char_Base);
            var Character3Panel = AddMenuItem<PictureBox>(new Vector2i(26, 14), new Vector2i(8, 20));
            Character3Panel.BackColor = Color.Red;
        }
    }
}
