namespace Lumi.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void disciplines_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new disciplinesPage());

    }

    private async void profile_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage());
    }

    private async void more_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutUsPage());
    }
}