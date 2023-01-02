using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services
{
  public class PreferenceService
  {
    public async Task<List<Preference>> GetPreferences()
    {
      return await GetPreferencesMock();
    }

    private async Task<List<Preference>> GetPreferencesMock()
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

      };
      return preferences;
    }
  }
}
