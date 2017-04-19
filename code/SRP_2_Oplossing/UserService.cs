using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2_Oplossing
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

    public interface IDatabase
    {
        void Save(User model);
    }
    public class DataBase:IDatabase
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

    public interface IValidatorService
    {

    }
    public class ValidatorService:IValidatorService
    {

    }
    public interface IEmailService
    {

    }
    public class EmailService : IEmailService
    {

    }

    public class UserService
    {
       
        IDatabase _database = new DataBase();
        IValidatorService _validatorService = new ValidatorService();
        IEmailService _emailService = new EmailService();

        public void Register(User model)
        {
            // Check if the model valid
            if (_validatorService.ValidateUser(model) == false)
            {
                throw new ValidationException(model.GetErrors());
            }

            // Save the user to database
            _database.Save(model);

            // Code to send email
            _emailService.SendUser(user);
        }
    }
}
