using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumi
{
    public class Light : IDemarrable
    {
        private bool _IsOn;

        public bool IsOn
        {
            get { return _IsOn; }
        }

        public Light()
        {
            //L'état initial de la lampe est éteint
            _IsOn = false;
        }

        public bool IsOnn()
        { return IsOn; }

        public override string ToString()
        {
            if (IsOn)
                return "LightAllumé";
            else
                return "LightEteint";
        }

        public void TurnOff()
        {
            _IsOn = false;
        }

        public void TurnOn()
        {
            _IsOn = true;
        }

    }
}
