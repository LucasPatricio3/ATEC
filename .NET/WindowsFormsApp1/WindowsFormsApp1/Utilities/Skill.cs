using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedBattlerProject.Utilities
{
    public abstract class Skill
    {
        public string name;
        public string description;
        public Bitmap skillIcon;
        public Bitmap skillIconHover;
        public Bitmap skillIconPress;

        public abstract void DoSkill();
    }
}
