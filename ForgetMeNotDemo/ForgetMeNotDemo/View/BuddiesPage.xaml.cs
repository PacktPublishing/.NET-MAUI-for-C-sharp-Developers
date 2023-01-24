using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo.View;

public partial class BuddiesPage : ContentPage
{
  private BuddiesViewModel vm;
	public BuddiesPage(BuddiesViewModel vm)
	{
    this.vm = vm;
    BindingContext = vm;
    
		InitializeComponent();
  }

  protected override async void OnAppearing()
  {
    base.OnAppearing();

    await vm.Init();
  }
}