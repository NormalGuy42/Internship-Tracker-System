using System;

namespace InternshipTracker
{
    public class Student
    {
        private int id;
        private int userId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime birthdate;
        private string major;
        private double gpa;

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

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0.0 || value > 4.0)
                    throw new ArgumentException("GPA must be between 0.0 and 4.0");
                gpa = value;
            }
        }

        public Student()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
            this.phoneNumber = string.Empty;
            this.major = string.Empty;
        }

        public Student(int id, int userId, string firstName, string lastName, string email,
                      string phoneNumber, DateTime birthdate, string major, double gpa)
        {
            this.Id = id;
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Birthdate = birthdate;
            this.Major = major;
            this.Gpa = gpa;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - Birthdate.Year;
            if (DateTime.Now.DayOfYear < Birthdate.DayOfYear)
                age--;
            return age;
        }

        public override string ToString()
        {
            return $"{GetFullName()} - {Major} (GPA: {Gpa:F2})";
        }
    }
}
