using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsNotEmpty(string prop)
        {
            return false;
        }

        public string GetErrors()
        {
            return "";
        }
    }
    public class DataBase
    {
        public void Save(User model) { }
    }
    public class SmtpClient
    {
        public void Send(string mail) { }
    }

    public class ValidationException : Exception
    {
        public ValidationException(string message)
        : base(message)
        {
        }
    }

    public class UserService
    {
        DataBase _database;
        string mail;
        public void Register(User model)
        {
            // Model validations
            if (model.IsNotEmpty(model.Username) == false || model.IsNotEmpty(model.Password) == false)
            {
                throw new ValidationException(model.GetErrors());
            }

            // Save to database
            _database.Save(model);

            // Code to send email
            var smtpClient = new SmtpClient();
            smtpClient.Send(mail);
        }
    }
}
