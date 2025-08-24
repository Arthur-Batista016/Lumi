namespace Lumi.Views;

public partial class disciplinesPage : ContentPage
{
	public disciplinesPage()
	{
		InitializeComponent();
	}
    private Border? bordaSelecionada = null;
    private Border? bordaProfessorSelecionada = null;

    private void pix_Clicked_1(object sender, EventArgs e)
    {
        AlternarSelecao(borda1);

    }

    private void debito_Clicked(object sender, EventArgs e)
    {
        AlternarSelecao(borda2);
    }

    private void credito_Clicked(object sender, EventArgs e)
    {
        AlternarSelecao(borda3);
    }

    private void AlternarSelecao(Border borda)
    {
        if (bordaProfessorSelecionada == borda)
        {
            borda.BackgroundColor = Color.FromArgb("#B7D0E1"); // laranja
            bordaProfessorSelecionada = null;
        }
        else
        {
            if (bordaProfessorSelecionada != null)
                bordaProfessorSelecionada.BackgroundColor = Color.FromArgb("#B7D0E1");

            borda.BackgroundColor = Color.FromArgb("#828282"); // verde
            bordaProfessorSelecionada = borda;
        }
    }

    

    private async void confirmar_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Aprovado", "Pagamento Realizado com Sucesso", "Ok");
        await Navigation.PushAsync(new HomePage());
    }

    private void materias_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = sender as Picker;

        if (picker.SelectedIndex != -1)
        {
            string valorSelecionado = picker.SelectedItem.ToString();

            if (valorSelecionado == "Química")
            {
                professores.IsVisible = true;
            }
            else
            {
                professores.IsVisible = false;
            }

        }
    }



    

    private void p2_Clicked(object sender, EventArgs e)
    {
        bp2.BackgroundColor = Color.FromArgb("858585");
        bp2.HorizontalOptions = LayoutOptions.Center;
        bp1.IsVisible = false;
        tipo.IsVisible = true;
    }

    private void p1_Clicked(object sender, EventArgs e)
    {
        bp2.BackgroundColor = Color.FromArgb("858585");
        bp1.HorizontalOptions = LayoutOptions.Center;
        bp2.IsVisible = false;
        tipo.IsVisible = true;
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        dias.IsVisible = true;
    }

    private void opcao1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        horarios.IsVisible = true;
    }

    private void opcao2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        pagamento.IsVisible = true;
    }
}