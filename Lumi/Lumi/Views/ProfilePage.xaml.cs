namespace Lumi.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void sair_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InitialPage());
    }
}