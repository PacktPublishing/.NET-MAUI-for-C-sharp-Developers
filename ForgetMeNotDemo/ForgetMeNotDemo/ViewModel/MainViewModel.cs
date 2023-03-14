using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class MainViewModel
{
  [ObservableProperty] private bool flowerIsVisible = true;

  [ObservableProperty] private string fullName;
  [ObservableProperty] private string favoriteFlower = "flower.png";

  [RelayCommand]
  private void ToggleFlowerVisibility()
  {
    FlowerIsVisible = !FlowerIsVisible;

  }

  [RelayCommand]
  private void ImageTapped()
  {
    FlowerIsVisible = !FlowerIsVisible;
  }

    [RelayCommand]
    private async void GoToLogin()
    {
        await Shell.Current.GoToAsync("loginpage");
    }


}

