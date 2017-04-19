using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC_2
{
    public class Hond2
    {
        public Hond2(string type)
        {
            Type = type;

        }
        public string Type { get; set; }
        public string Blaf()
        {
            switch (Type)
            {
                case "Poedel":
                    return "waf waf";
                case "Golden Retriever":
                    return "wof wof";

            }
            return null;
        }

        public string Eet()
        {
            switch (Type)
            {
                case "Poedel":
                    return "ham ham ham";
                case "Golden Retriever":
                    return "njammie";

            }
            return null;
        }
    }
}
