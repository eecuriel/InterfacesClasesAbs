using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClasesAbs
{
    public  class BlueKoopa : Koopa, IShell, ISwim
    {
        private readonly int _legs;
        private IShell _shell;
        private ISwim _swim;

        public BlueKoopa(int legs) : base(legs)
        {
            _legs = legs;
            _shell = new ShellColor();
            _swim = new Swim();
        }

        public string CrearKoopa()
        {
            string result = $"Este koopa tiene {_legs}";

            return result;
        }

        public string ShellAction(string shellColor)
        {
            var shellAction = _shell.ShellAction(shellColor);
           
            return shellAction;

        }

        public string Swim()
        {
            var koopaPuedeNadar = _swim.Swim();
            return koopaPuedeNadar;
        }
    }
}
