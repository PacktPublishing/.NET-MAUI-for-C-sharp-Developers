using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ForgetMeNotDemo.View;

namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class LoginViewModel
{
  [ObservableProperty] private string name;
  [ObservableProperty] private string password;

  [ObservableProperty] private string lostPasswordExcuse;
  [ObservableProperty] private bool editorContentVisible = true;
  [ObservableProperty] private bool activityIndicatorIsRunning = true;

  [RelayCommand]
  private async void Submit()
  {

    for (double i = 0.0; i < 1.0; i += 0.1)
    {
      await LoginPage.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
    }

    await Application.Current.MainPage.DisplayAlert(
      "Submit",
      $"You entered {Name} and {Password}",
      "OK");

  }

  [RelayCommand]
  private void Create()
  {
    WeakReferenceMessenger.Default.Send(new ConstructMessage());

  }
}