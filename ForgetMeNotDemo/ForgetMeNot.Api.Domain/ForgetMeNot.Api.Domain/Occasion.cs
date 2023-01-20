namespace ForgetMeNot.Api.Domain
{
    public class Occasion
    {
        public Occasion()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        // Who is this occasion for?
        // For example would be the user who is having a birthday
        // But for occasions that involve more than one user, it would be empty (an anniversary)
        public User? ForUser { get; set; }
        public string? OccasionName { get; set; }
        public DateTime Date { get; set; }
        public int NumDaysToNotify { get; set; }
    }
}