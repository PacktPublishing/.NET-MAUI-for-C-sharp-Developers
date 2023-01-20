using CommunityToolkit.Maui.Core.Views;
using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class LoginPage : ContentPage
{
  public LoginPage(LoginViewModel viewModel)
  {
    BindingContext = viewModel;
    InitializeComponent();
  }
}