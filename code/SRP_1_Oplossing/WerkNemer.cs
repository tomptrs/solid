using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_1_Oplossing
{
    public class Werknemer
    {
        Database db;
        ILogger logger;
        public Werknemer(ILogger log)
        {
            db = new Database();
            logger = log;

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
