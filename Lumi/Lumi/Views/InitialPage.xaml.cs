namespace Lumi.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();
	}

    private void register_Clicked(object sender, EventArgs e)
    {
        
    }

    private async  void login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}