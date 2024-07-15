using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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

        private GameMenu currentMenu;

        public static int cellWidth;
        public static int cellHeight;

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

            PartySelectionMenu menu = new PartySelectionMenu();
            currentMenu = menu;
            currentMenu.InitializeMenuControls();

            BackColor = Pallete.GreenishBlue;

            Debug.WriteLine($"CW{cellWidth}, CH{cellHeight}");
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            currentMenu.DrawObjects(currentMenu.gameObjects.ToArray());
        }
    }
}
