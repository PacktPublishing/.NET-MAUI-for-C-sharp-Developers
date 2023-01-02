using CommunityToolkit.Mvvm.ComponentModel;

namespace ForgetMeNotDemo.Model;

[ObservableObject]
public partial class Preference
{
  [ObservableProperty] private string preferencePrompt;
  [ObservableProperty] private string preferenceValue;

}