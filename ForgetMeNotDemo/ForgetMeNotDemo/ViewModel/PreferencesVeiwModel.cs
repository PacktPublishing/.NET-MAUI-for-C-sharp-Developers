using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNotDemo.Model;
using ForgetMeNotDemo.Services;

namespace ForgetMeNotDemo.ViewModel;
[ObservableObject]
public partial class PreferencesViewModel
{
  [ObservableProperty] private List<Preference> preferenceList;

  private IPreferenceService service;

  
  public PreferencesViewModel(IPreferenceService service)
  {
    this.service = service;
  }

  public async Task Init()
  {
    PreferenceList = await service.GetPreferences();
  }
  
}

