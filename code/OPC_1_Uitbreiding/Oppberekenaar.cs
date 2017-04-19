using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC_1_Uitbreiding
{
    public class Rechthoek
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Cirkel
    {
        public int Straal { get; set; }
    }
    public class OppBerekenaar
    {
        public double Opp(Object[] shapes)
        {
            double opp = 0;
            foreach (var shape in shapes)
            {
                if(shape is Rechthoek)
                    opp += ((Rechthoek)shape).Width * ((Rechthoek)shape).Height;
                if(shape is Cirkel)
                {
                    opp += ((Cirkel)shape).Straal * ((Cirkel)shape).Straal * Math.PI;
                }
            }

            return opp;
        }
    }
}
