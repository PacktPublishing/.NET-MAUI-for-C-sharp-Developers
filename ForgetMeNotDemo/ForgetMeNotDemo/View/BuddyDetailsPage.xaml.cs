using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class BuddyDetailsPage : ContentPage
{
	public BuddyDetailsPage()
  {
    BindingContext = new BuddyDetailsViewModel();
		InitializeComponent();
	}
}