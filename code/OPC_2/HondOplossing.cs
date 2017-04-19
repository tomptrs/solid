using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC_2
{
    public abstract class HondOpl
    {
        public virtual string Blaf()
        {
            return "Woef";
        }

        public virtual string Eet()
        {
            return "njam..";
        }
    }

    public class Poedel : HondOpl
    {
        public override string Blaf()
        {
            return "waf waf";
        }

        public override string Eet()
        {
            return "ham ham ham";
        }
    }
}
