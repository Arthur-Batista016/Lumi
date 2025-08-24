namespace Lumi.Views;

public partial class AboutUsPage : ContentPage
{
	public AboutUsPage()
	{
		InitializeComponent();
	}

    private async void voltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new HomePage());
    }
}