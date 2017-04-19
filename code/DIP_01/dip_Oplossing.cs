using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_01_1
{
    class EventLogWriter
    {
        public void Write(string message)
        {
            //Write to event log here
        }
    }

    class EmailLogWriter
    {
        public void Send(string message)
        {
            //Send email
        }
    }

    class Printer
    {

        EventLogWriter writer = null;
        EmailLogWriter email = null;


        public void Notify(string message, string type)
        {
            if (type == "EventViewer")
            {
                if (writer == null)
                {
                    writer = new EventLogWriter();
                }
                writer.Write(message);
            }

            if (type == "email")
            {
                if (email == null)
                {
                    email = new EmailLogWriter();
                }
                email.Send(message);
            }
        }
    }
}
