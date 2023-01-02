using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class Preferences : ContentPage
{
  private PreferencesViewModel vm;
	public Preferences()
  {
    vm = new PreferencesViewModel();
    BindingContext = vm;
		InitializeComponent();
	}

  protected override async void OnAppearing()
  {
    base.OnAppearing();
    await vm.Init();
  }
  
  


}