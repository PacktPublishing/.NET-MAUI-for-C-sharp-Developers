using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Storage;

namespace ForgetMeNotDemo.ViewModel;
[ObservableObject]
public partial class UserPreferencesViewModel 
{
  [ObservableProperty] private string displayName;
  [ObservableProperty] private string themeSelection;
  [ObservableProperty] private bool wifiOnly;
  public string ThemeGroupName => "Theme";

  [RelayCommand]
  public async Task SavePreferences()
  {
    Preferences.Default.Set("DisplayName", displayName);
    Preferences.Default.Set("ThemeSelection", themeSelection);
    Preferences.Default.Set("WifiOnly", wifiOnly);
  }

  public UserPreferencesViewModel()
  {
    DisplayName = Preferences.Default.Get("DisplayName", "Unknown");
    ThemeSelection = Preferences.Default.Get("ThemeSelection", "Light");
    WifiOnly = Preferences.Default.Get("WifiOnly", false);
  }
}

