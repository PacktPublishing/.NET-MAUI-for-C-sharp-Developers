using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class AboutViewModel
{

  [ObservableProperty] private string apiVersion;

  public AboutViewModel()
  {
    apiVersion = "1.0";
  }

  [RelayCommand]
  public async Task OpenPreferences()
  { 
    await Shell.Current.GoToAsync($"userpreferences");

  }

}

