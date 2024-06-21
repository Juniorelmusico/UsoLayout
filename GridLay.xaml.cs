using Microsoft.Maui.Controls;

namespace UsoLayout;

public partial class GridLay : ContentPage
{
	public GridLay()
	{
        InitializeComponent();
	}

	private async void IrStackLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutDemo());
    }
}