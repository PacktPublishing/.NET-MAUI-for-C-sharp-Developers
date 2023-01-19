using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ForgetMeNot.Api.Dto;
using ForgetMeNotDemo.Services;
using ForgetMeNotDemo;

namespace ForgetMeNotDemo.ViewModel
{
  [ObservableObject]
  public partial class LoginViewModel
  {
    private AccountService accountService;
    [ObservableProperty] private string loginName;
    [ObservableProperty] private string password;
    [ObservableProperty] private bool showActivityIndicator = false;

    public LoginViewModel(AccountService accountService)
    {
      this.accountService = accountService;
    }


    [RelayCommand]
    public async Task DoLogin()
    {

      try
      {
        LoginRequest loginRequest = new LoginRequest
        {
          Username = LoginName,
          Password = Password
        };

        ShowActivityIndicator = true;
        await accountService.Login(loginRequest);
        ShowActivityIndicator = false;

        if (accountService.IsLoggedIn())
        {
          Application.Current.MainPage = new AppShell();
          await Shell.Current.GoToAsync("mainpage");
        }
        else
        {

          await Application.Current.MainPage.DisplayAlert("Login failure",
              "Your username and password do not match our records", "Ok");
        }

      }
      catch (Exception exception)
      {
        await Application.Current.MainPage.DisplayAlert("Authorization failure",
            "Your username and password do not match our records", "Ok");

        Console.WriteLine(exception);
      }


    }

    [RelayCommand]
    public async Task ForgotPassword()
    {

    }

    [RelayCommand]
    public async Task DoCreateAccount()
    {
      try
      {
        Application.Current.MainPage = new AppShell();

        await Shell.Current.GoToAsync($"createaccount");

      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
    }
  }
}
