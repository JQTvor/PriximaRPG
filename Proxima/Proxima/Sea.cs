using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima
{
    class Sea : RoomParent
    {
        public void SeaGo() 
        {

            Console.WriteLine("{0} \n {1} \n {2} \n", this.RoomName(),this.Description(),this.Monsters());

            MoveLoop:
            string input = Console.ReadLine().ToLower();

            if(input == "go east")
            {
                Landing l = new Landing();
                l.LandingGo();
            }
            else if(input == "perceive" || input == "p")
            {
                //call skills class
                Console.WriteLine("{0}", this.Description());
                goto MoveLoop;
            }
            else if(input == "p ship" || input == "perceive ship")
            {
                Console.WriteLine("The ship is a hulking mass of wood floating next you.  The saliors and man in golden armor have gone out of view.");
                goto MoveLoop;
            }
            else if(input == "p land" || input == "perceive land")
            {
                Console.WriteLine("Cliffs with sheer, 100's of feet, drops line the seas edge.  There is a small sandy beach directly to the east");
                goto MoveLoop;
            }
            else if(input == "exit")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Unknown Command");
                SeaGo();
            }
        }
        public override string RoomName()
        {
            return "Saffron Sea";
        }

        public override string Description()
        {
            return "The water is surprising warm.  You see land to the east and the current starts to lazily drag you towards it.";
        }

    }
}
