using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP02
{
    /*
     We gaan even verder met het voorbeeldje dat we bij het vorige principe hebben gebruikt.
     We hebben een Arbeider en een Robot.We maken nu een manager die een bepaalde werker 
     moet managen. Een fout tegen DIP zou zijn dat we de Arbeider toevoegen aan de
     manager klasse, dit zou willen zeggen dat de manager afhankelijk is van de
     Arbeider klasse. manager is ook niet flexibel genoeg om eventueel andere werkers
     op te vangen.
     Een oplossing hiervoor is de dependency leggen naar een IWorkable interface.
     De manager klasse wordt losgekoppeld en is een pak flexibeler om eventuele
     andere werkers op te vangen.

 */
    class Arbeider
    {
        public void Werk()
        {
            //doe iets
        }
    }

    class Manager
    {
        Arbeider a;

        void Manage()
        {
            a.Werk();
        }
    }
}
