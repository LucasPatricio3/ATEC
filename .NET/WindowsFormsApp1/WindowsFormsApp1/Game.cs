using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnBasedBattlerProject.Menus;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject
{
    public partial class Game : Form
    {
        public static Graphics graphics;
        public static PointF resizeConst;
        public static Game instance;

        public static GameMenu currentMenu;

        public static int cellWidth;
        public static int cellHeight;

        public static Random random = new Random();

        public GameObject character1;
        public GameObject character2;
        public GameObject character3;

        public Game()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            instance = this;

            //Applies Resolution to App
            instance.Size = Screen.PrimaryScreen.Bounds.Size;

            resizeConst = new PointF(instance.Width / 320, instance.Height / 180);

            cellWidth = instance.Size.Width / 32;
            cellHeight = instance.Size.Height / 18;

            BackColor = Pallete.GreenishBlue;

            ChangeMenu<PartySelectionMenu>();

            Debug.WriteLine($"CW{cellWidth}, CH{cellHeight}");
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            currentMenu.DrawObjects(currentMenu.gameObjects.ToArray());
        }

        public static void ChangeMenu<T>() where T : GameMenu, new()
        {
            T menu = new T();
            currentMenu = menu;
            currentMenu.InitializeMenuControls();
        }

        public void SaveCharacters(GameObject character1, GameObject character2, GameObject character3)
        {
            this.character1 = character1;
        }
    }
}
