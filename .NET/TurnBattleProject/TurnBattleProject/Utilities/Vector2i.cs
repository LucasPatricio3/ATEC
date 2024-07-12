using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBattleProject.Utilities
{
    public class Vector2i
    {
        public int x;
        public int y;

        public Vector2i()
        {
            x = 0;
            y = 0;
        }
        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2i Clamp(Vector2i vector, int MinValue, int MaxValue)
        {
            vector.x = Math.Clamp(vector.x, MinValue, MaxValue);
            vector.y = Math.Clamp(vector.y, MinValue, MaxValue);
            return vector;
        }
    }
}
