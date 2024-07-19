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
    internal class TwinSlashSkill : Skill
    {
        public TwinSlashSkill()
        {
            name = "Twin Slash";
            description = "Lorem Ipsum";
            skillIcon = Resources.TwinStrikeSkillIcon;
            skillIconHover = Resources.TwinStrikeSkillIconHover;
            skillIconPress = Resources.TwinStrikeSkillIconPress;
        }
        public override void DoSkill()
        {
            throw new NotImplementedException();
        }
    }
}