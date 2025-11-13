using System;

namespace InternshipTracker
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Major { get; set; }
        public double Gpa { get; set; }

        public Student()
        {
        }

        public Student(int id, int userId, string firstName, string lastName, string email,
                      string phoneNumber, DateTime birthdate, string major, double gpa)
        {
            Id = id;
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthdate = birthdate;
            Major = major;
            Gpa = gpa;
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
