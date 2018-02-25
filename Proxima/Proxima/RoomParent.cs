using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima
{
    abstract class RoomParent
    {
        public virtual string Description()
        {
            return " ";
        }
        public virtual string Monsters()
        {
            return " ";
        }

        public virtual string RoomName()
        {
            return " ";
        }

    }
}
