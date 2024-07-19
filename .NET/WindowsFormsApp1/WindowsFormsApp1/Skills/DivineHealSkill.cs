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
    internal class DivineHealSkill : Skill
    {
        public DivineHealSkill()
        {
            name = "Divine Heal";
            description = "Lorem Ipsum";
            skillIcon = Resources.DivineHealSkillIcon;
            skillIconHover = Resources.DivineHealSkillIconHover;
            skillIconPress = Resources.DivineHealSkillIconPress;
        }
        public override void DoSkill()
        {
            throw new NotImplementedException();
        }
    }
}