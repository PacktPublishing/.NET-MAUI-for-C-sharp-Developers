using ForgetMeNot.Api.Domain;

namespace ForgetMeNot.Api.Dto
{
    public class ProfileUpdateRequest
    {
        public string FullName { get; set; }

        /// <remarks>
        /// Currently using user preferences, but if there are any changes between properties on the domain object
        ///   and what we send/receive, it should be implemented on their own DTO object
        /// </remarks>
        public List<UserPreference> Preferences { get; set; }
    }
}
