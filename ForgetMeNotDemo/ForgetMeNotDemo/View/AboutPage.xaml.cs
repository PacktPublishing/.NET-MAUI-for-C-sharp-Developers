using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class AboutPage : ContentPage
{
	public AboutPage()
  {
    BindingContext = new AboutViewModel();
		InitializeComponent();
	}
}