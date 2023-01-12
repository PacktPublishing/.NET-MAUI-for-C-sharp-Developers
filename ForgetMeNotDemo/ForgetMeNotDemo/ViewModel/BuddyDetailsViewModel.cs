#nullable enable
using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
//[QueryProperty(nameof(Id), "id")]
//[QueryProperty(nameof(Name), "buddyname")]
[QueryProperty(nameof(MyBuddy), "TheBuddy")]
public partial class BuddyDetailsViewModel
{
  [ObservableProperty] private string id;
  [ObservableProperty] private string name;
  [ObservableProperty] private string? website;

  private Buddy myBuddy;

  public Buddy MyBuddy
  {
    get => myBuddy;
    set
    {
      Id = value.Id;
      Name = value.Name;
      Website = value.Website;
    }
  }
  


}

