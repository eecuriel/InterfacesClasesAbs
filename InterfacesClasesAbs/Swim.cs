using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClasesAbs
{
    public class Swim : ISwim
    {
        string ISwim.Swim()
        {
            return "Koopa puede nadar";
        }
    }
}
