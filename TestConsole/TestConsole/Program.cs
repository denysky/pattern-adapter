using LumChine;
using Lumi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Lumiere l = new Lumiere();
            LumiereAdapter a = new LumiereAdapter(l);
            Button n = new Button(a);
           
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(i + "      " + l);
                Console.WriteLine();
                n.Press();
            }

          

            Console.ReadKey();
        }
    }
}
