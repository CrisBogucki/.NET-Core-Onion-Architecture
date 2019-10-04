using System;

namespace SampleApp.Core.Domain
{
    public class User : Entity
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        
        protected User()
        {
        }
        public User(string firstName, string lastName, string email, string password)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetEmail(email);
            SetPassword(password);
            CreatedAt = DateTime.UtcNow;
        }
        public void SetFirstName(string firstName)
        {
            if(string.IsNullOrWhiteSpace(firstName))
            {
                throw new Exception($"User can not have an empty first name.");
            }
            FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            if(string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception($"User can not have an empty last name..");
            }
            LastName = lastName;
        }
        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                throw new Exception($"User can not have an empty email.");
            }
            Email = email;
        }
        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new Exception($"User can not have an empty password.");
            }
            Password = password;
        }
    }
}