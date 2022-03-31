using WarriorWars.Enum;
namespace WarriorWars.Equipment
{

    class Armor{
        private int armorpoints;
        private const int GOOD_GUY_ARMOR=5;
        private const int BAD_GUY_ARMOR=5;


        public int ArmorPoints{
            get{
                return armorpoints;
            }
        }

        public Armor(Faction faction)
        {
            switch(faction)
            {
                case Faction.Goodguy:
                    armorpoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.Badguy:
                    armorpoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}