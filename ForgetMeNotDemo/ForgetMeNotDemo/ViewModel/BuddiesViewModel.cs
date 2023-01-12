using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.ViewModel
{
  [ObservableObject]
  public partial class BuddiesViewModel
  {
    //[ObservableProperty] private string id = "001";
    //[ObservableProperty] private string name = "jesse";

    [ObservableProperty] private Buddy rodrigo = new Buddy
    {
      Id = "002",
      Name = "Rodrigo Juarez",
      Website = "https://jesseliberty.com"
    };
    

    // [RelayCommand]
    // private async Task GoToDetails()
    // {
    //   await Shell.Current.GoToAsync($"buddydetailspage?id={Id}&&buddyname={Name}");
    //
    // }

    [RelayCommand]
    private async Task GoToDetails()
    {
      var navigationParameter = new Dictionary<string, object>
      {
        {"TheBuddy", Rodrigo}
      };

      await Shell.Current.GoToAsync($"buddydetailspage", navigationParameter);
    }


  }
}
