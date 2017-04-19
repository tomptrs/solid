using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_1
{
    public class AreaCalculator
    {
        public static int CalculateObject(Rechthoek r)
        {
            return r.Width * r.Height;
        }

        public static int CalculateObject(Vierkant v)
        {
            return v.Width * v.Width;
        }
    }
    public class Rechthoek
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
    }

    public class Vierkant : Rechthoek
    {
        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
