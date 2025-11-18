using System;

namespace InternshipTracker
{
    public class Admin
    {
        private int id;
        private int userId;
        private string firstName;
        private string lastName;
        private string email;
        private string department;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public Admin()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
            this.department = string.Empty;
        }

        public Admin(int id, int userId, string firstName, string lastName, 
                     string email, string department)
        {
            this.Id = id;
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Department = department;
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public override string ToString()
        {
            return $"{GetFullName()} - {department}";
        }
    }
}

