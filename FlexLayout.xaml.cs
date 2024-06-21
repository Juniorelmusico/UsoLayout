using System.Runtime.InteropServices.ObjectiveC;
namespace UsoLayout;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

	private async void IrAbsoluteLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }
}