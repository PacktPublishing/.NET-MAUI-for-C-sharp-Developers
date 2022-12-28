using ForgetMeNotDemo.ViewModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ForgetMeNotDemo.View;

public partial class LoginPage : ContentPage
{
	LoginViewModel vm = new LoginViewModel();
	public LoginPage()
	{
		BindingContext = vm;
    InitializeComponent();
	}

  //private bool activityIndicatorIsRunning = true;

  //public bool ActivityIndicatorIsRunning
  //{
  //  get => activityIndicatorIsRunning;
  //  set
  //  {
  //    activityIndicatorIsRunning = value;
  //    OnPropertyChanged();
  //  }
  //}
  private async void OnSubmit(object sender, EventArgs e)
  {

    await DisplayAlert(
      "Submit", 
      $"You entered {vm.Name} and {vm.Password}", 
      "OK");

  }

  //private async void OnCreate(object sender, EventArgs e)
  //{
  //  CreateAccount.Text = (await DisplayAlert(
  //    "Create?", 
  //    "Did you want to create an account?", 
  //    "Yes", 
  //    "No")).ToString();
  //}

  private async void OnForgotPassword(object sender, EventArgs e)
  {
    CreateAccount.Text = (await DisplayActionSheet(
      "How can we solve this?",
      "Cancel",
      null,
      "Get new password",
      "Show me my hint",
      "Delete account"));
  }

  //private async void OnCreate(object sender, EventArgs e)
  //{
  //  CreateAccount.Text = await DisplayPromptAsync(
  //    title:"New Account", 
  //    message:"How old are you?", 
  //    placeholder:"Please enter your age", 
  //    keyboard:Keyboard.Numeric, 
  //    accept: "OK", 
  //    cancel: "Cancel");
    
  //}

  //private async void OnCreate(object sender, EventArgs e)
  //{
  //    CancellationTokenSource cancellationTokenSource = 
  //      new CancellationTokenSource();
  //    var message = "Your account was created";
  //    ToastDuration duration = ToastDuration.;
  //    var fontSize = 14;
  //    var toast = Toast.Make(message, duration, fontSize);
  //    await toast.Show(cancellationTokenSource.Token);

  //}

  private async void OnCreate(object sender, EventArgs e)
  {
    CancellationTokenSource cancellationTokenSource =
      new CancellationTokenSource();
    var message = "Your account was created";
    var dismissalText = "Click Here to Close the SnackBar";
    TimeSpan duration = TimeSpan.FromSeconds(10);

    Action action = async () =>
      await DisplayAlert(
        "Snackbar Dismissed!", 
        "The user has dismissed the snackbar", 
        "OK");

    var snackbarOptions = new SnackbarOptions
    {
      BackgroundColor = Colors.Red,
      TextColor = Colors.Yellow,
      ActionButtonTextColor = Colors.Black,
      CornerRadius = new CornerRadius(20),
      Font = Microsoft.Maui.Font.SystemFontOfSize(14),
      ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14)
    };

    var snackbar = Snackbar.Make(
      message, 
      action, 
      dismissalText, 
      duration, 
      snackbarOptions);

    await snackbar.Show(cancellationTokenSource.Token);

    vm.ActivityIndicatorIsRunning = false;
  }



}