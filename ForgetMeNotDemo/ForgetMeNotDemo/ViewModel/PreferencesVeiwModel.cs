using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNotDemo.Model;
using ForgetMeNotDemo.Services;

namespace ForgetMeNotDemo.ViewModel;
[ObservableObject]
public partial class PreferencesViewModel
{
  [ObservableProperty] private List<Preference> preferenceList;
  private readonly PreferenceService service;
  
  public PreferencesViewModel()
  {
    service = new();
  }

  public async Task Init()
  {
    PreferenceList = await service.GetPreferences();
  }
  
}

