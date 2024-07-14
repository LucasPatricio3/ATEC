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
using static System.Net.Mime.MediaTypeNames;

namespace TurnBasedBattlerProject
{
    public partial class Window : Form
    {
        public static Graphics graphics;

        public static Window instance;

        public static int cellWidth;
        public static int cellHeight;

        public Window()
        {
            InitializeComponent();
            instance = this;

            //Applies Resolution to App
            instance.Size = Screen.PrimaryScreen.Bounds.Size;

            cellWidth = instance.Size.Width/32;
            cellHeight = instance.Size.Height/18;

            BackColor = Color.CadetBlue;

            Debug.WriteLine($"CW{cellWidth}, CH{cellHeight}");
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            PartySelectionMenu menu = new PartySelectionMenu();
            menu.InitializeMenu();
        }
    }
}
