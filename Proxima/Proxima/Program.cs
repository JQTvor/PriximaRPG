using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Bios b = new Bios();
            Sea s = new Sea();
            Console.WriteLine("Welcome! \n {0} \n", b.Opening());
            s.SeaGo();

        }
    }
}
