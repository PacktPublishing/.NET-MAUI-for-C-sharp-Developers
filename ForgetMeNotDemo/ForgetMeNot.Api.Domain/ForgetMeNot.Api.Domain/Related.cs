namespace ForgetMeNot.Api.Domain
{
    public class Related
    {
        public Related()
        {
            Occasions = new List<Occasion>();
            Users = new List<User>();
        }

        public Guid Id { get; set; }
        public string RelatedDescription { get; set; }
        
        public List<User> Users { get; set; }
        public List<Occasion> Occasions { get; set; }
        public DateTime Since { get; set; }
    }
}
