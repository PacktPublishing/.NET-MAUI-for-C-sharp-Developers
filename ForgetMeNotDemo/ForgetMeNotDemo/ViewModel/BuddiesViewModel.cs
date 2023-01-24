using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ForgetMeNotDemo.Model;
using System.Diagnostics;
using ForgetMeNotDemo.Services;

namespace ForgetMeNotDemo.ViewModel
{
  [ObservableObject]
  public partial class BuddiesViewModel
  {
    [ObservableProperty] private Buddy selectedBuddy;

    [ObservableProperty] private List<Buddy> buddies;

    private readonly IBuddyService buddyService;


    public BuddiesViewModel(IBuddyService buddyService)
    {
      this.buddyService = buddyService;
    }

    public async Task Init()
    {
      try
      {
        Buddies = await buddyService.GetBuddies();
      }
      catch (Exception ex)
      {
        // TODO: logging
        Debug.WriteLine("Unable to retrieve buddy list" + ex.Message);
      }
    }



    [RelayCommand]
    private async Task AddBuddy()
    {
      //Useful if you're sending canned email
      //var contact = await Microsoft.Maui.ApplicationModel.Communication.Contacts.PickContactAsync();
      //var contact = await Contacts.Default.PickContactAsync();
      //if (contact != null)
      //{
      //    var givenName = contact.GivenName;
      //    var familyName = contact.FamilyName;
      //    List<ContactEmail> emails = contact.Emails;
      //}


      var text =
          "I'd like to invite you to become a buddy in Forget Me Not. You'll need the app which you can get from the app store. Once you have it set up, click on this link:\n\n" +
          LinkService.GetUri() +
          "\n\nThat will establish us as buddies, and you can see my preferences. Don't forget to set up your preferences so that I can see them when I want to get you a present.\n\n Hope you will join me.";

      await ShareText(text);


      //await ShareUri(uri, Share.Default);
    }



    public async Task ShareText(string text)
    {
      await Share.Default.RequestAsync(new ShareTextRequest
      {
        Text = text,
        Title = "Share Text"
      });
    }


    //public async Task ShareUri(string uri, IShare share)
    //{
    //    await share.RequestAsync(new ShareTextRequest
    //    {
    //        Uri = uri,
    //        Title = "Share Web Link"
    //    });
    //}

    [RelayCommand]
    private async Task BuddySelectionChanged()
    {

      var navigationParameter = new Dictionary<string, object>
      {
          {"SelectedBuddy", SelectedBuddy}
      };

      await Shell.Current.GoToAsync($"buddydetailspage", navigationParameter);

    }

  }

}
