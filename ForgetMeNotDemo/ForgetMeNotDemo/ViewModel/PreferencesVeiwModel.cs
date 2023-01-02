using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNotDemo.Model;
using ForgetMeNotDemo.Services;

namespace ForgetMeNotDemo.ViewModel;
[ObservableObject]
public partial class PreferencesViewModel
{
  [ObservableProperty] private List<Preference> preferences;
  private readonly PreferenceService service;
  
  public PreferencesViewModel()
  {
    service = new();
  }

  public async Task Init()
  {
    Preferences = await service.GetPreferences();
  }
  
}

