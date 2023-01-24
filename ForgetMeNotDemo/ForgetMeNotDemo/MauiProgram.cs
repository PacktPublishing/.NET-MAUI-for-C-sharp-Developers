using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using ForgetMeNot.ApiClient;
using ForgetMeNot.ViewModel;
using ForgetMeNotDemo.Services;
using ForgetMeNotDemo.View;
using ForgetMeNotDemo.ViewModel;
using Microsoft.Extensions.Logging;

namespace ForgetMeNotDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
    builder
      .UseMauiApp<App>()
      .UseMauiCommunityToolkit()
      .UseMauiCommunityToolkitMarkup()
      .ConfigureFonts(fonts =>
      {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
      })
      .UseMauiMaps();

#if DEBUG
		builder.Logging.AddDebug();
#endif

    // Pages
    builder.Services.AddTransient<AboutPage>();
    builder.Services.AddTransient<BuddiesPage>();
    builder.Services.AddTransient<BuddyDetailsPage>();
    builder.Services.AddTransient<PreferencesPage>();
    builder.Services.AddTransient<LoginPage>();
    builder.Services.AddTransient<CreateAccountPage>();
    builder.Services.AddTransient<MainPage>();

    var apiClient = new Client("https://forgetmenotapi20230113114628.azurewebsites.net/");
    builder.Services.AddSingleton(apiClient);


    // Services
    builder.Services.AddTransient<IPreferenceService, PreferenceService>();
    builder.Services.AddTransient<IBuddyService, BuddyService>();
    builder.Services.AddTransient<AccountService>();


    // ViewModels
    builder.Services.AddTransient<AboutViewModel>();
    builder.Services.AddTransient<BuddiesViewModel>();
    builder.Services.AddTransient<BuddyDetailsViewModel>();
    builder.Services.AddTransient<PreferencesViewModel>();
    builder.Services.AddTransient<LoginViewModel>();
    builder.Services.AddTransient<CreateAccountViewModel>();

    return builder.Build();
	}
}
