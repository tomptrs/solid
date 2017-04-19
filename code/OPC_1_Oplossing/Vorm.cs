using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC_1_Oplossing
{
    public abstract class Vorm
    {
        public abstract double Oppervlakte();
    }

    public class Rechthoek : Vorm
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override double Oppervlakte()
        {
            return Width * Height;
        }
    }

    public class Cirkel : Vorm
    {

        public int Straal { get; set; }

        public override double Oppervlakte()
        {
            return Straal * Straal * Math.PI;
        }
    }


    public class OppBerekenaar
    {

        public double Opp(Vorm[] shapes)
        {
            double opp = 0;
            foreach (var shape in shapes)
            {
                opp += shape.Oppervlakte();
            }

            return opp;
        }

    }
}
