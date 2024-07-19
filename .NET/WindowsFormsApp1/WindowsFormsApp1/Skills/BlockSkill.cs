using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Skills
{
    internal class BlockSkill : Skill
    {
        public BlockSkill()
        {
            name = "Block";
            description = "Lorem Ipsum";
            skillIcon = Resources.BlockSkillIcon;
            skillIconHover = Resources.BlockSkillIconHover;
            skillIconPress = Resources.BlockSkillIconPress;
        }
        public override void DoSkill()
        {
            throw new NotImplementedException();
        }
    }
}