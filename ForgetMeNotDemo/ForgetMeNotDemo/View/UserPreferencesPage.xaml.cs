using ForgetMeNotDemo.ViewModel;
namespace ForgetMeNotDemo.View;

public partial class UserPreferencesPage : ContentPage
{
	public UserPreferencesPage()
  {
    BindingContext = new UserPreferencesViewModel();
		InitializeComponent();
	}
}