using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumi
{
    public class Button
    {
        public IDemarrable Demarre;
        public Button(IDemarrable demarre)
        {
            Demarre = demarre;
        }
        public void Press()
        {
            if (Demarre.IsOnn())
                Demarre.TurnOff();
            else
                Demarre.TurnOn();
        }

    }
}
