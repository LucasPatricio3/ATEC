using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Skills
{
    public class StrikeSkill : Skill
    {
        public StrikeSkill()
        {
            name = "Strike";
            description = "Lorem Ipsum";
            skillIcon = Resources.StrikeSkillIcon;
            skillIconHover = Resources.StrikeSkillIconHover;
            skillIconPress = Resources.StrikeSkillIconPress;
        }
        public override void DoSkill()
        {
            throw new NotImplementedException();
        }
    }
}
