using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class LoginPage : ContentPage
{
	LoginViewModel vm = new LoginViewModel();
	public LoginPage()
	{
		BindingContext = vm;
		InitializeComponent();
	}
}