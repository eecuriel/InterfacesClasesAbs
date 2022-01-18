using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClasesAbs
{
    public class RedKoopa : Koopa, IShell, IFly
    {

        private readonly int _legs;
        private IShell _shell;
        public RedKoopa(int legs) : base(legs)
        {
            _legs = legs;
            _shell = new ShellColor();
        }

        public string Fly()
        {
            return "Este Koopa puede volar";
        }

        public string ShellAction(string shellColor)
        {
            var shellAction = _shell.ShellAction(shellColor);
            return shellAction;

        }

        public string CrearKoopa()
        {
            string result = $"Este koopa tiene {_legs}";

            return result;
        }

    }

}
