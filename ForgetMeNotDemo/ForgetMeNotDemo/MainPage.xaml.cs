namespace ForgetMeNotDemo;

public partial class MainPage : ContentPage
{
	private int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		CounterBtn.Text = count == 1 
      ? $"Clicked {count} time" 
      : $"Clicked {count} times";

    ClickCounterLabel.Text = CounterBtn.Text;


    SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

