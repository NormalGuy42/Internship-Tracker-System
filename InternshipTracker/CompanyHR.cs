using System;

namespace InternshipTracker
{
    public class CompanyHR
    {
        private int id;
        private int userId;
        private int companyId;
        private string firstName;
        private string lastName;
        private string email;

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

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
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

        public CompanyHR()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
        }

        public CompanyHR(int id, int userId, int companyId, string firstName, string lastName, string email)
        {
            this.Id = id;
            this.UserId = userId;
            this.CompanyId = companyId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"{GetFullName()} - {Email}";
        }
    }
}