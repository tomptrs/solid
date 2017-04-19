using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_1
{
    public interface ILog
    {
        void Log(string message);
       
        void OpenConnection();

        void CloseConnection();

    }


    public class DBLogger : ILog
    {
        public void Log(string message)
        {
            //Code to log data to a database
        }

        public void OpenConnection()
        {
            //Opens database connection
        }

        public void CloseConnection()
        {
            //Closes the database connection
        }

    }

    public class FileLogger : ILog
    {
        public void Log(string message)
        {
            //Code to log to a file           
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

    }
}
