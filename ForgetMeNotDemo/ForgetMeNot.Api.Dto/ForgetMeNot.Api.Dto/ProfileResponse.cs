using ForgetMeNot.Api.Domain;

namespace ForgetMeNot.Api.Dto;

public class ProfileResponse
{
  public Guid Id { get; set; }
  public string FullName { get; set; }
  public string Email { get; set; }
  public bool IsEmailConfirmed { get; set; }
  public string Role { get; set; }

  /// <remarks>
  /// Currently using user preferences, but if there are any changes between properties on the domain object
  ///   and what we send/receive, it should be implemented on their own DTO object
  /// </remarks>
  public List<UserPreference> Preferences { get; set; }

  public ProfileResponse()
  {

  }

  public ProfileResponse(User user)
  {
    Id = user.Id;
    FullName = user.FullName;
    Email = user.Email;
    Role = user.Role;
    IsEmailConfirmed = user.IsEmailConfirmed;
    Preferences = user.Preferences;
  }
}
