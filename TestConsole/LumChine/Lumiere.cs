using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumChine
{
    public class Lumiere
    {
        private bool _IsLightOn;

        public Lumiere()
        {
            //à la création la lampe est éteinte
            _IsLightOn = false;
        }

        public void LightOn()
        {
            _IsLightOn = true;
        }
        public void LightOff()
        {
            _IsLightOn = false;
        }

        public bool IsLightOn
        {
            get { return _IsLightOn; }

        }

        public override string ToString()
        {
            if (IsLightOn)
                return "Allumé";
            else
                return "Eteint";
        }

    }
}
