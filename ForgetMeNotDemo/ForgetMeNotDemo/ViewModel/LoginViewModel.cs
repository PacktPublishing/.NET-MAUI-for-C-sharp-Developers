using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class LoginViewModel
{
  [ObservableProperty] private string name;
  [ObservableProperty] private string password;
  [ObservableProperty] private string lostPasswordExcuse;
  [ObservableProperty] private bool editorContentVisible = true;

 //private bool editorContentVisible = true;

 //public bool EditorContentVisible
 //{
 //  get => editorContentVisible;
 //  set
 //  {
 //    editorContentVisible = value;
 //     OnPropertyChanged();
 //   }
 //}

 public ICommand EditorCompletedCommand { get; }

  public LoginViewModel()
  {
    EditorCompletedCommand = new Command(() => EditorContentVisible = false);
  }

}