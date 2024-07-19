using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Skills;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Components
{
    public class CharacterData : GameComponent
    {
        public string characterName;
        private CharacterClass characterClass;

        public Skill skill1;
        public Skill skill2;
        public Skill skill3;

        private static Bitmap[] hairStyles = new Bitmap[] {
            Resources.Hair0,
            Resources.Hair1,
            Resources.Hair2,
            Resources.Hair3,
            Resources.Hair4,
            Resources.Hair5,
            Resources.Hair6,
            Resources.Hair7,
            Resources.Hair8,
            Resources.Hair9
        };

        public void GenerateCharacter(SpriteRenderer classIconRenderer, SpriteRenderer characterRenderer)
        {
            characterName = "Clive";
            characterClass = (CharacterClass)Game.random.Next(3);
            classIconRenderer.image = GetClassIcon();
            characterRenderer.image = GetCharacterVisual();
            GenerateSkills();
        }

        private Bitmap GetCharacterVisual()
        {
            var baseCharacter = new Bitmap(Resources.Char_Base_Sheet_24x24);

            var result = new Bitmap(32, 32, PixelFormat.Format32bppArgb);

            using (var graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(baseCharacter, new PointF(0, 0));
                graphics.DrawImage(hairStyles[Game.random.Next(hairStyles.Length)], new PointF(0, 0));
                graphics.DrawImage(GetOutfit(), new PointF(0, 0));
            }

            return result;
        }
        private Bitmap GetOutfit()
        {
            switch (characterClass)
            {
                case CharacterClass.Warrior:
                    return Resources.WarriorOutfit1;

                case CharacterClass.Mage:
                    return Resources.MageOutfit1;

                case CharacterClass.Priest:
                    return Resources.PriestOutfit1;

                default:
                    return Resources.MissingTextureBlock;
            }
        }
        private Bitmap GetClassIcon()
        {
            switch (characterClass)
            {
                case CharacterClass.Warrior:
                    return Resources.warriorIcon;
                case CharacterClass.Mage:
                    return Resources.mageIcon;
                case CharacterClass.Priest:
                    return Resources.priestIcon;
            }
            return Resources.MissingTextureBlock;
        }
        private void GenerateSkills()
        {
            switch (characterClass)
            {
                case CharacterClass.Warrior:
                    skill1 = new StrikeSkill();
                    skill2 = new BlockSkill();
                    skill3 = new TwinSlashSkill();
                    break;
                case CharacterClass.Mage:
                    skill1 = new StrikeSkill();
                    skill2 = new StrikeSkill();
                    skill3 = new StrikeSkill();
                    break;
                case CharacterClass.Priest:
                    skill1 = new StrikeSkill();
                    skill2 = new HealSkill();
                    skill3 = new DivineHealSkill();
                    break;
            }
        }


        public void DisplaySkills(ImageButon skill1Button, ImageButon skill2Button, ImageButon skill3Button)
        {
            skill1Button.MapBitmaps(skill1.skillIcon, skill1.skillIconHover, skill1.skillIconPress);
            skill2Button.MapBitmaps(skill2.skillIcon, skill2.skillIconHover, skill2.skillIconPress);
            skill3Button.MapBitmaps(skill3.skillIcon, skill3.skillIconHover, skill3.skillIconPress);
        }

    }

    public enum CharacterClass
    {
        Warrior,
        Mage,
        Priest,
    }
}
