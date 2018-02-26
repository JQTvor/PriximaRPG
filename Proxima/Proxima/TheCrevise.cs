using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima
{
    class TheCrevise : RoomParent
    {
        public void Crevise()
        {
            Console.WriteLine("{0}\n" + "{1}\n" + "{2}\n", this.RoomName(), this.Description(), this.Monsters());

        MoveLoop:
            string input = Console.ReadLine().ToLower() ;

            //move commands
            if(input == "go crevise")
            {
                TheCrevise Crevise = new TheCrevise();
                Console.WriteLine("You head outside.");
                Crevise.Crevise();
                
            }
            //if(input == "go passage")
            //{
            //    Passage pass = new Passage();
            //    {
            //        Console.WriteLine("You head down the passage");
            //        pass.Passage();
            //    }
            //}



            goto MoveLoop;

        }

        public override string Description()
        {
            return "The sand spills into this room as it slopes upward.  On the north side are two crates that seem mostly untouched by weather. \n"+
                "The wall to your left slopes northeast until it hits the north wall where the crates sit.  Around the crates are 4 kobolds who \n"+
                "who seem surprised by your sudden appearance.  In the southeast corner is a passage.";
        }

        public override string Monsters()
        {
            return "kobold, kobold, kobold, kobold";
        }

        public override string RoomName()
        {
            return "The Crevise";
        }
    }
}
