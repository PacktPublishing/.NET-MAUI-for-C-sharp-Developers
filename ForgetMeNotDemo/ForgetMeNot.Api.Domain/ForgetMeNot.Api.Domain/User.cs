namespace ForgetMeNot.Api.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string Role { get; set; }
        public List<UserPreference> Preferences { get; set; }
    }
}
