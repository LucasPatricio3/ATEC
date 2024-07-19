using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Skills
{
    internal class HealSkill : Skill
    {
        public HealSkill()
        {
            name = "Heal";
            description = "Lorem Ipsum";
            skillIcon = Resources.HealSkillIcon;
            skillIconHover = Resources.HealSkillIconHover;
            skillIconPress = Resources.HealSkillIconPress;
        }
        public override void DoSkill()
        {
            throw new NotImplementedException();
        }
    }
}
