using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_01
{
    class EventLogWriter
    {
        public void Write(string message)
        {
            //Write to event log here
        }
    }

    class Printer
    {
        // Handle to EventLog writer to write to the logs
        EventLogWriter writer = null;

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (writer == null)
            {
                writer = new EventLogWriter();
            }
            writer.Write(message);
        }
    }
}
