using ForgetMeNot.Api.Domain;

namespace ForgetMeNot.Api.Dto
{
    public class BuddyDto
    {
        public BuddyDto()
        {

        }

        public BuddyDto(User user)
        {
            UserId = user.Id;
            FullName = user.FullName;
            Email = user.Email;

            Preferences = new List<UserPreference>();
            if (user.Preferences?.Any(p => p.PreferenceValue != null) ?? false)
            {
                Preferences = user.Preferences.Where(p => p.PreferenceValue != null).ToList();
            }

            Occasions = new List<OccasionDto>();
        }

        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<UserPreference> Preferences { get; set; }
        public List<OccasionDto> Occasions { get; set; }
    }
}
