using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ForgetMeNotDemo.Services;
using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class PreferencesPage : ContentPage
{
  private PreferencesViewModel vm;
	public PreferencesPage()
  {
    IPreferenceService service = new PreferenceService();
    vm = new PreferencesViewModel(service);
    BindingContext = vm;
		InitializeComponent();
	}

  protected override async void OnAppearing()
  {
    base.OnAppearing();
    await vm.Init();
  }

  public void SavePreferences(object sender, EventArgs e)
  {
    ShowToast();
  }

  private async Task ShowToast()
  {
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    var message = "Your preferences were saved";
    ToastDuration duration = ToastDuration.Short;
    var fontSize = 14;
    var toast = Toast.Make(message, duration, fontSize);
    await toast.Show(cancellationTokenSource.Token);

  }



}