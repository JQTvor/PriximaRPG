using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima
{
    class Landing : RoomParent
    {


        public void LandingGo()
        {
            Console.WriteLine("{0} \n {1} \n {2} \n", this.RoomName(), this.Description(), this.Monsters());

        MoveLoop:
            string input = Console.ReadLine().ToLower();

            if (input == "perceive crates" || input == "p crates")
            {
                Console.WriteLine("The crates are rotting and useless.  What ever items they once held have long since disspeared.");
                goto MoveLoop;
            }


            if (input == "perceive" || input == "p")
            {
                Random p = new Random();
                int rng = p.Next(1, 21);
                Console.WriteLine("You look about.  Roll: " + rng);
                if (rng < 10)
                {
                    Console.WriteLine("{0}", this.Description());
                    goto MoveLoop;
                }
                else if (rng > 10)
                {
                    Console.WriteLine("{0} \nThere is a pile of rope that lays in a disshevled pile near the north east cliff and a \n" +
                                        "5 foot cravess that looks as if it leads into the cliff.", this.Description());
                    goto MoveLoop;
                }
            }
            if (input == "exit")
            {
                Environment.Exit(1);
            }
            else
            {

                Console.WriteLine("Unknown Command");
                LandingGo();


            }


        }

        public override string RoomName()
        {
            return "The Landing";
        }
        public override string Description()
        {
            return "You crawl on shore, soaking wet, items strapped to the backpack on your back.  The 200 foot swim from the ship was \n" +
                    "easy compaired to what must lay a head.  The beach is a mix of khaki sand and greyish green smooth stones.  There are \n" +
                    "four creates scattered about, all mostly wet-rotted away.";
        }

    }
}
