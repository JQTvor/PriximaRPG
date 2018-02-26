using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima
{
    class Landing : RoomParent
    {
        Random p = new Random();

        public void LandingGo()
        {
            Console.WriteLine("{0} \n {1} \n {2} \n", this.RoomName(), this.Description(), this.Monsters());

        MoveLoop:
            string input = Console.ReadLine().ToLower();

            //Preceviable items in room.
            if (input == "perceive crates" || input == "p crates")
            {
                Console.WriteLine("The crates are rotting and useless.  Whatever items they once held have long since disspeared.");
                goto MoveLoop;
            }

            if (input == "p rope" || input == "preceive rope")
            {
                Random rope = new Random();
                int rng = rope.Next(1, 21);
                Console.WriteLine("You look at the rope.  Roll: " + rng);
                Console.WriteLine("The rope is frayed in numerous places.  It lays in a disheveled pile.  With so many weak spots, it appears worthless.");
                if (rng > 10)
                {
                    Console.WriteLine("You see the end of a frayed portion of the rope dangling about 100 feet up.");
                    goto MoveLoop;
                }
                else
                {
                    goto MoveLoop;
                }


            }
            
            
            //Perception of this area, the sea, and the crevice.
            if (input == "perceive" || input == "p")
            {

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
                                        "5 foot crevice that looks as if it leads into the cliff.", this.Description());
                    goto MoveLoop;
                }
            }
            if (input == "p sea" || input == "perception sea")
            {
                Sea s = new Sea();
                Console.WriteLine(s.Description());
            }
            if (input == "p crevise" || input == "perception crevice")
            {
                int rng = p.Next(1, 21);
                Console.WriteLine("You look and listen into the crevice.  Roll: " + rng);
                Console.WriteLine("The crevise is dark and forboding.");
                if (rng >= 20)
                {
                    Console.WriteLine("You hear yips and kips coming from inside.");
                }
                goto MoveLoop;
            }

            if (input == "exit")
            {
                Environment.Exit(1);
            }
 

            
            
            //Travel Commands
            if (input == "go sea")
            {
                int rng = p.Next(1, 21);
                Console.WriteLine("The current fights you as you try to swin.  Roll: " + rng);
                if (rng >= 10)
                {
                    Sea s = new Sea();
                    Console.WriteLine("You swim out to sea.");
                    s.SeaGo();
                }
                else
                {
                    Console.WriteLine("The current is too strong to swim against.");
                    goto MoveLoop;
                }

            }

            if (input == "go crevise")
            {
                TheCrevise Crevise = new TheCrevise();
                Console.WriteLine("You enter the crevice.");
                Crevise.Crevise();
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
                    "four crates scattered about, all mostly wet-rotted away.";
        }

    }
}
