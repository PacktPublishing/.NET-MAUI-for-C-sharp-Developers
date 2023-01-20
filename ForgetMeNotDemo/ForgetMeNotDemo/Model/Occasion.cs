using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ForgetMeNotDemo.Model;

[ObservableObject]
public partial class Occasion
{
  [ObservableProperty] private string name;
  [ObservableProperty] private DateTime date;
  [ObservableProperty] private int numDaysToNotify;
}
