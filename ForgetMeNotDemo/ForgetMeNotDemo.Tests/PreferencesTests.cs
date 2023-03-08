using ForgetMeNotDemo.Model;
using ForgetMeNotDemo.Services;
using ForgetMeNotDemo.ViewModel;
using NSubstitute;

namespace ForgetMeNotDemo.Tests;

public class PreferencesTests
{
  
  private PreferencesViewModel preferencesViewModel;
  
  //IPreferenceService service = new PreferenceService();
  

  [Fact]
  public void MustBeTrue()
  {
    Assert.True(true);
  }

  [Fact]
  public async void AfterCallingInitPreferencesIsNotEmpty()
  {
    // Arrange

    Preference pref1 = new()
    {
      PreferencePrompt = "Shirt Size",
      PreferenceValue = "Large"
    };

    Preference pref2 = new()
    {
      PreferencePrompt = "Favorite Music Genre",
      PreferenceValue = "Jazz"
    };

    List<Preference> prefs = new()
    {
      pref1,
      pref2
    };

    var serviceMock = Substitute.For<IPreferenceService>();
      serviceMock.GetPreferences()
      .Returns(prefs);

    
    preferencesViewModel = new PreferencesViewModel(serviceMock);

    // Act
    await preferencesViewModel.Init();

    // Assert
    Assert.NotEmpty(preferencesViewModel.PreferenceList);
  }

  [Fact]
  public async void AfterCallingInitPreferencesIsEmptyButNoException()
  {
    // Arrange
    List<Preference> preferences = new();
    
    var serviceMock = Substitute.For<IPreferenceService>();
    serviceMock.GetPreferences()
      .Returns(preferences);


    preferencesViewModel = new PreferencesViewModel(serviceMock);

    // Act
    var exception = await Record.ExceptionAsync (async () => await preferencesViewModel.Init());

    // Assert
    Assert.Null(exception);
  }

  [Fact]
  public async void AfterCallingInitPreferencesIsNullButNoException()
  {
    // Arrange
    List<Preference>? preferences = null;

    var serviceMock = Substitute.For<IPreferenceService>();
    serviceMock.GetPreferences()
      .Returns(preferences);


    preferencesViewModel = new PreferencesViewModel(serviceMock);

    // Act
    var exception = await Record.ExceptionAsync(async () => await preferencesViewModel.Init());

    // Assert
    Assert.Null(exception);
  }


}
