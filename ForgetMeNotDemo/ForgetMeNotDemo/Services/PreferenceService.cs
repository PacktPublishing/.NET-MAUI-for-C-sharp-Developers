using ForgetMeNot.ApiClient;
using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services;

public class PreferenceService : IPreferenceService
{
  readonly Client apiClient;

  public PreferenceService(Client apiClient)
  {
    this.apiClient = apiClient;
  }
  public async Task<List<Preference>> GetPreferences()
  {
    try
    {
      var response = await apiClient.GetProfile();
      return response?.Preferences.Select(p => new Preference
      {
        PreferencePrompt = p.PreferencePrompt,
        PreferenceValue = p.PreferenceValue

      }).ToList();
    }
    catch (Exception e)
    {
      await Application.Current.MainPage.DisplayAlert("Preferences error",
        "We were unable to get your preferences", "Ok");

      Console.WriteLine(e);
    }

    return null;

  }

}

