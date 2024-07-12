using System.Windows.Forms;
using TurnBattleProject.Utilities;
using TurnBattleProject.Utilities.Menus;

namespace TurnBattleProject
{
    public partial class Window : Form
    {
        public static Menu[] menus;
        public Window()
        {
            InitializeComponent();

            //Sets size of the form to Screen size
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Size = screen.Bounds.Size;

            PartySelectionMenu menu = new PartySelectionMenu(this.Size.Width, this.Size.Height);
            menu.InitializeMenu(this);
        }
    }
}
