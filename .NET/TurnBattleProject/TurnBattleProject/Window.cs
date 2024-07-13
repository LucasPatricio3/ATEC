using System.Windows.Forms;
using TurnBattleProject.Menus;
using TurnBattleProject.Utilities;

namespace TurnBattleProject
{
    public partial class Window : Form
    {
        public static Window Instance;
        public static Menu[] menus;
        public Window()
        {
            InitializeComponent();
            Instance = this;

            //Sets size of the form to Screen size
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Size = screen.Bounds.Size;

            PartySelectionMenu menu = new PartySelectionMenu(this.Size.Width, this.Size.Height);
            menu.InitializeMenu(this);
        }
    }
}
