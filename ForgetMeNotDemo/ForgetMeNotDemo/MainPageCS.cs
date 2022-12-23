using CommunityToolkit.Maui.Markup;

namespace ForgetMeNotDemo;

class MainPageCS : ContentPage
{
  private readonly Button counterBtn = new Button
  {
    Text = "Click Me",
    HorizontalOptions = LayoutOptions.Center,
  }.SemanticHint("Counts the number of times you click");

  private readonly Label clickCounterLabel = new Label
    {
      HorizontalOptions = LayoutOptions.Center,
      Text = "Click the Button",
    }.SemanticDescription("Label for counter info")
    .SemanticHeadingLevel(SemanticHeadingLevel.Level2);


  public MainPageCS()
  {
    counterBtn.Clicked += OnCounterClicked;

    Content = new VerticalStackLayout
    {
      Spacing = 30,
      Padding = new Thickness(30, 0),
      VerticalOptions = LayoutOptions.Center,
      Children =
                {
                    new Image()
                    {
                        Source = "dotnet_bot.png",
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                    }.SemanticDescription("Cute dot net bot waving hi to you!"),

                    new Label()
                    {
                        Text="Hello, World",
                        FontSize=32,
                        HorizontalOptions = LayoutOptions.Center,
                    }.SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                    new Label()
                    {
                        Text = "Welcome to .NET Multi-platform App UI",
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                    }.SemanticHeadingLevel(SemanticHeadingLevel.Level2)
                        .SemanticDescription("Welcome to dot net Multi platform App U I"),

                    counterBtn,
                    clickCounterLabel,
                }
    };
  }

  private int count = 0;
  private void OnCounterClicked(object sender, EventArgs e)
  {
    count++;

    if (count == 1)
      counterBtn.Text = $"Clicked {count} time";
    else
      counterBtn.Text = $"Clicked {count} times";

    SemanticScreenReader.Announce(counterBtn.Text);
  }
}

