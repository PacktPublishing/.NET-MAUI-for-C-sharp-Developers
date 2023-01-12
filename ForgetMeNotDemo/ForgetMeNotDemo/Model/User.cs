using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ForgetMeNotDemo.Model
{
  [ObservableObject]
  public partial class User
  {
    [ObservableProperty] private string name;

    [ObservableProperty] private string id;

    [ObservableProperty] private List<Buddy> buddies;

   // [ObservableProperty] private List<Invitation> invitations;

    [ObservableProperty] private List<Preference> preferences;

  }

}
