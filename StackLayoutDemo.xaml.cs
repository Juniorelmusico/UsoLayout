namespace UsoLayout;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
	InitializeComponent();
	}

	private async void FlexLayout(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new FlexLayout());
	}
}