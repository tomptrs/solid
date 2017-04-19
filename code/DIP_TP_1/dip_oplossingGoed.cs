using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_01_2
{
    interface INotification
    {
        void Notify(string message);
    }

    class EventLogWriter : INotification
    {
        public void Notify(string message)
        {
        }

    }

    class EmailLogWriter : INotification
    {
        public void Notify(string message)
        {

        }


    }

    class Printer
    {

        INotification writer;

        public Printer(INotification w)
        {
            writer = w;
        }
        public void Notify(string message)
        {

            writer.Notify(message);
        }
    }
}
