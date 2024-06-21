namespace UsoLayout;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private async void IrGridLay(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLay());
    }
}