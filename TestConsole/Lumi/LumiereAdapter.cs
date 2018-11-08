using LumChine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumi
{
    public class LumiereAdapter : IDemarrable
    {
        private Lumiere Obj { get; set; }
        public LumiereAdapter(Lumiere obj)
        {
            Obj = obj;
        }

        public void TurnOn()
        {
            Obj.LightOn();
        }

        public void TurnOff()
        {
            Obj.LightOff();
        }

        public bool IsOnn()
        {
            return Obj.IsLightOn;
        }
    }
}
