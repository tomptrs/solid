using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_1_Oplossing
{
    public interface ILog
    {
        void Log(string message);     

    }

    public interface IDBLog :ILog
    {
        void OpenConnection();

        void CloseConnection();
    }

    public interface IFileLog :ILog
    {
        void CheckFileSize();

        void GenerateFileName();
    }


    public class DBLogger : IDBLog
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

    public class FileLogger : IFileLog
    {
        public void Log(string message)
        {
            //Code to log data to a database
        }
        public void CheckFileSize() { }

        public void GenerateFileName() { }
    }


}

