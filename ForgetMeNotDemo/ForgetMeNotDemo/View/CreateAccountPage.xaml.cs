using ForgetMeNot.ViewModel;
using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class CreateAccountPage : ContentPage
{

  public CreateAccountPage(CreateAccountViewModel vm)
  {
    BindingContext = vm;
		InitializeComponent();
	}
}