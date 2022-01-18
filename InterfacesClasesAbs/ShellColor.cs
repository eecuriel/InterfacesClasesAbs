using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClasesAbs
{
    internal class ShellColor : IShell
    {
        public string ShellAction(string shellColor)
        {
            string result = "";
            if (shellColor == "Red")
            {
                result = "Dan vueltas al llegar una borde ";

            }
            else if (shellColor == "Yellow")
            {
                result = "Son pesados  y se detienen al llegar una borde ";
            }
            else if (shellColor == "Blue")
            {
                result = "Son más rápidos y Dan vueltas al llegar una borde y esperar 10 segundos";
            }
            else if (shellColor == "Green")
            {
                result = "Si llegan a un borde se caen";
            }
            return result;
        }

    }
}
