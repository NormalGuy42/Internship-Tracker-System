using System;

namespace InternshipTracker
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string role;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public User()
        {
            this.username = string.Empty;
            this.password = string.Empty;
            this.role = string.Empty;
        }

        public User(int id, string username, string password, string role)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public override string ToString()
        {
            return $"{Username} ({Role})";
        }
    }
}