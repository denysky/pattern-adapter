using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumi
{
    public class Other : IDemarrable
    {
        private bool _IsOn;

        public bool IsOn
        {
            get { return _IsOn; }
        }

        public Other()
        {
            //L'état initial d'other est éteint
            _IsOn = false;
        }



        public override string ToString()
        {
            if (IsOn)
                return "OtherOtherise";
            else
                return "OtherNoOtherise";
        }

        public void TurnOff()
        {
            _IsOn = false;
        }

        public void TurnOn()
        {
            _IsOn = true;
        }
        public bool IsOnn()
        { return IsOn; }

    }
}
