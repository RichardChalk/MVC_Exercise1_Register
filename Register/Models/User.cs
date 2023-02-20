namespace Register.ViewModels
{
    public class User
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool SendMeUpdates { get; set; } = false;

    }
}
