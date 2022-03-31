using WarriorWars.Enum;
namespace WarriorWars
{
    class Entrypoint
    {
        static Random rng = new Random();
        static void Main()
        {
            Warrior goodGuy = new Warrior("Shashank",Faction.Goodguy);
            Warrior badGuy = new Warrior("Agni",Faction.Badguy);

            while(goodGuy.IsAlive && badGuy.IsAlive)
            {
                if(rng.Next(0, 10)<5)
                {
                    goodGuy.Attack(badGuy);
                }

                else{
                badGuy.Attack(goodGuy);
                }
            }

        }
    }
}