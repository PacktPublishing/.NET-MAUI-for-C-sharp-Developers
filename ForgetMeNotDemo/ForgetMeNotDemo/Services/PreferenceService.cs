using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services;

public class PreferenceService : IPreferenceService
{
  public async Task<List<Preference>> GetPreferences()
  {
    return await GetPreferencesMock();
  }

  public async Task<List<Preference>> GetPreferencesMock()
  {
    List<Preference> preferences = new()
      {
        new Preference()
        {
          PreferencePrompt = "Shirt Size",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Music Genre",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Color",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Food",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Movie",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite TV Show",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Book",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Sport",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Animal",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Favorite Music",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },
        new Preference()
        {
          PreferencePrompt = "Preference",
          PreferenceValue = ""
        },

      };
    return preferences;
  }
}

