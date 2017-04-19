using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC_1
{
    public class Rechthoek
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class OppBerekenaar
    {
        public double Opp(Rechthoek[] shapes)
        {
            double opp = 0;
            foreach (var shape in shapes)
            {
                opp += shape.Width * shape.Height;
            }

            return opp;
        }
    }
}
