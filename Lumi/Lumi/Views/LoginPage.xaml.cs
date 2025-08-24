


namespace Lumi.Views;

public partial class LoginPage : ContentPage
{
	public string emailCadastrado = "bilinho@gmail.com";
	public string senhaCadastrada = "1234";
	

	public LoginPage()
	{
		InitializeComponent();
	
	}

	public async void realizarLogin()
	{
		string email = emailText.Text;
		string senha = senhaText.Text;

		if(senha == senhaCadastrada && email == emailCadastrado)
		{
			DisplayAlert("SUCESSO !", "Login realizado com sucesso", "Ok");
            await Navigation.PushAsync(new HomePage());
        }
		else{
            DisplayAlert("ERRO", "Email ou Senha incorretos", "Ok");
        }
	}

    private async void entrar_Clicked(object sender, EventArgs e)
    {
		realizarLogin();
      
    }

    private async void voltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new InitialPage());
    }
}