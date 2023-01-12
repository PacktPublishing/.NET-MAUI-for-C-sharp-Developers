using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class BuddiesPage : ContentPage
{
	public BuddiesPage()
	{
		InitializeComponent();
    BindingContext = new BuddiesViewModel();
  }
}