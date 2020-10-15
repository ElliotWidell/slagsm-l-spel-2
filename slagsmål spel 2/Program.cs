using System;

namespace slagsmål_spel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            string player = "";
            string fiende = "";
            string weapon1 = "";
            string weapon2 = "";
            string weapon3 = "";
            string weapon4 = "";
            string weapon5 = "";
            string weaponname1 = "Infinity Edge (Your attacks do 5 more damage and you have a 20% chanse to dubble your damage every round)";
            string weaponname2 = "Blood Thirster (Your attacks do 10 more damage and you heal for 25% of the damage you deal)";
            string weaponname3 = "Chain Vest (You take 10 less damage)";
            string weaponname4 = "Giant Slayer (You do 20 more damage)";
            string weaponname5 = "Sword Of The Divine (You have a 50% chanse to dubble your damage every round)";
            string weaponname6 = "Deadmans Plate (You take 20 less damage)";
            string weaponname7 = "Trinity Force (You do 10 more damage, take 10 less damage and heal for 10% of the damage you deal)";
            int playerhp = generator.Next(100, 150);
            int fiendehp = generator.Next(150, 200);
            int playerdmg = generator.Next(15, 25);
            int fiendedmg = generator.Next(20, 30);
            int fiendenamn = generator.Next(1, 6);
            int weapon1ID = generator.Next(1, 8);
            int weapon2ID = generator.Next(1, 8);
            int weapon3ID = generator.Next(1, 8);
            int weapon4ID = generator.Next(1, 8);
            int weapon5ID = generator.Next(1, 8);



            if (fiendenamn == 1)
            {
                fiende = "osama bin laden";

            }


            if (fiendenamn == 2)
            {
                fiende = "Elliot Widell";

            }

            if (fiendenamn == 3)
            {
                fiende = "Ronald McDonald";

            }


            if (fiendenamn == 4)
            {
                fiende = "Tay-k";

            }

            if (fiendenamn == 5)
            {
                fiende = "Gabe Newell";

            }

            if (weapon1ID == 1)
            {

                weapon1 = weaponname1;

            }
            if (weapon1ID == 2)
            {

                weapon1 = weaponname2;

            }

            if (weapon1ID == 3)
            {

                weapon1 = weaponname3;

            }

            if (weapon1ID == 4)
            {

                weapon1 = weaponname4;

            }
            if (weapon1ID == 5)
            {

                weapon1 = weaponname5;

            }
            if (weapon1ID == 6)
            {

                weapon1 = weaponname6;

            }

            if (weapon1ID == 7)
            {

                weapon1 = weaponname7;

            }



            //yoyoyoyyoyoyo







            Console.WriteLine("Hello warrior what is your name?:");

            player = Console.ReadLine();

            Console.WriteLine("very well " + player + ", you are about to walk into the arena of a big coloseum and fight " + fiende + " but befor that you need some equipment");

            Console.ReadLine();



        }
    }
}
