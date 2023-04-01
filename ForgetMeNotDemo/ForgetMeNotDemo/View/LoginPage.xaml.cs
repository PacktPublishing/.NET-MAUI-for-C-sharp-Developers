using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class LoginPage : ContentPage {
    public LoginPage(LoginViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        passwordEntry.Text = "";
        LoginNameEntry.Text = "";

    }
}