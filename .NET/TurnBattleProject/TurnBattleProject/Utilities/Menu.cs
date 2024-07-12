using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBattleProject.Utilities
{
    public abstract class Menu
    {
        public List<Control> menuItems = new List<Control>();

        private const int gridSize = 32;

        private int gridCellWidth;
        private int gridCellHeight;
        public Menu(int screenCellWidth, int screenCellHeight)
        {
            gridCellWidth = screenCellWidth / gridSize;
            gridCellHeight = screenCellHeight / gridSize;
        }
        public T AddMenuItem<T>(Vector2i gridPosition, Vector2i size) where T : Control, new()
        {
            //Clamps Vectors to fix wrong values
            gridPosition = Vector2i.Clamp(gridPosition, 0, gridSize - 1);
            size = Vector2i.Clamp(size, 1, gridSize);

            //Initializes Item
            T item = new T();

            item.Left = gridCellWidth * gridPosition.x - (gridCellWidth * size.x / 2);
            item.Top = gridCellHeight * gridPosition.y - (gridCellHeight * size.y / 2);

            item.Size = new Size(gridCellWidth * size.x, gridCellHeight * size.y);

            menuItems.Add(item);
            return item;
        }
        public void InitializeMenu(Form window)
        {
            window.Controls.Clear();
            window.Controls.AddRange(menuItems.ToArray());
        }
    }
}
