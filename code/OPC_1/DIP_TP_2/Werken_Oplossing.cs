using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP02_1
{
    interface IWorkable
    {
        void Werk();
    }
    class Arbeider:IWorkable
    {
        public void Werk()
        {
            //doe iets
        }
    }

    class Manager
    {         
        void Manage(IWorkable a)
        {
            a.Werk();
        }
    }
}
