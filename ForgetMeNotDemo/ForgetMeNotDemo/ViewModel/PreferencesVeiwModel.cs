using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

  [RelayCommand]
  private async Task SavePreferencesAsync()
  {
    await service.Save(PreferenceList);
  }

}

