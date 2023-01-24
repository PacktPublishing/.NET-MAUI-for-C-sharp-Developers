using ForgetMeNot.Api.Dto;
using ForgetMeNot.ApiClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services
{
  public class BuddyService : IBuddyService
  {
    readonly Client apiClient;


    public BuddyService(Client apiClient)
    {
      this.apiClient = apiClient;
    }

    public async Task<List<Buddy>> GetBuddies()
    {
      var buddies = new List<Buddy>();
      var buddy = new Buddy();

      try
      {
        var response = await apiClient.GetBuddy();
        if (response is null) return buddies;

        foreach (BuddyDto dto in response)
        {
          buddy.Id = dto.UserId.ToString();
          buddy.Name = dto.FullName;
          buddy.EmailAddress = dto.Email;
          buddies.Add(buddy);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
      return buddies;
    }

    public List<Preference> GetBuddyPreferences(string buddyId)
    {
      return GetBuddyPreferencesMock(buddyId);
    }

    private List<Preference> GetBuddyPreferencesMock(string buddyId)
    {

      List<Preference> preferences = new();
      Preference preference = new Preference
      {
        PreferencePrompt = "Shirt size",
        PreferenceValue = "xxl"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Pants size",
        PreferenceValue = "40"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Shoe size",
        PreferenceValue = "12"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Favorite books",
        PreferenceValue = "Ulysses, Hamnet, Let's pretend this never happened, The Road, Zen and the art, Snow Crash"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Book genres",
        PreferenceValue = "Literary fiction, history, politics, philosophy"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "TV Shows",
        PreferenceValue = "Sense8, West Wing, Left Behind"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Music Genres",
        PreferenceValue = "Eclectic but especially Hard Bop, Jazz in general, Classic rock, all sorts of 'classical'"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Hobbies",
        PreferenceValue = "Writing, Photography"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Interests",
        PreferenceValue = ""
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Pets",
        PreferenceValue = "Dog"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Political interests",
        PreferenceValue = ""
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Favorite Magazines",
        PreferenceValue = "The Atlantic"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Favorite Newspapers",
        PreferenceValue = "NYTimes, Washington Post"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Favorite Podcasts",
        PreferenceValue = "Political Gabfest, Hacks On Tap, Pod Save America"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Social Media",
        PreferenceValue = "Facebook, but only friends"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Programming Language",
        PreferenceValue = "C#"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Programming Framework",
        PreferenceValue = ".NeT MAUI"
      };
      CheckPreference(preference, preferences);

      preference = new()
      {
        PreferencePrompt = "Other languages",
        PreferenceValue = "Assembly, ASP.NeT Core, Spanish"
      };
      CheckPreference(preference, preferences);


      return preferences;
    }

    private void CheckPreference(Preference preference, List<Preference> preferences)
    {
      try
      {
        if (!string.IsNullOrEmpty(preference.PreferenceValue))
          preferences.Add(preference);

      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
    }
  }

}
