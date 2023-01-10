using CommunityToolkit.Mvvm.ComponentModel;
namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class AboutViewModel
{

  [ObservableProperty] private string apiVersion;

  public AboutViewModel()
  {
    apiVersion = "1.0";
  }

}

