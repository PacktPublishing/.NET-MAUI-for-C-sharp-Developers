using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class LoginViewModel
{
  [ObservableProperty] private string name;
  [ObservableProperty] private string password;
  [ObservableProperty] private string lostPasswordExcuse;
  [ObservableProperty] private bool editorContentVisible = true;
  [ObservableProperty] private bool activityIndicatorIsRunning = true;


}