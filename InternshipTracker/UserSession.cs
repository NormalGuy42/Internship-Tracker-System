namespace InternshipTracker
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int ProfileId { get; set; } // StudentID, CompanyHRID, SupervisorID, etc.

        public static void ClearSession()
        {
            UserId = 0;
            Username = string.Empty;
            Role = string.Empty;
            ProfileId = 0;
        }

        public static bool IsLoggedIn()
        {
            return UserId > 0 && !string.IsNullOrEmpty(Role);
        }
    }
}