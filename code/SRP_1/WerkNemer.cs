using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_1
{
    public class Werknemer
    {
        Database db;
        FileLogger logger;
        public Werknemer()
        {
            db = new Database();
            logger = new FileLogger();
        }
        void Insert()
        {
            try
            {

                string sql = "insert into werknemers(voornaam,achternaam,stad) values ('Tom', 'Peeters', 'Antwerpen')";
                db.Query(sql);
            }
            catch (Exception e)
            {
                //Log error
                logger.Log(e.ToString());
            }
        }

        void Delete()
        {

        }

        void Update()
        {

        }
    }
}
