using CommunityToolkit.Mvvm.ComponentModel;

namespace ForgetMeNotDemo.Model;

[ObservableObject]
public partial class Invitation
{

  [ObservableProperty] private string buddyCode;
  [ObservableProperty] private int buddyId;
}
