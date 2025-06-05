using Progreso2Ruales.Services;

namespace Progreso2Ruales;

public partial class Chistes : ContentPage
{
    private readonly JokesApi _jokeService = new JokesApi();

    public Chistes()
    {
        InitializeComponent();
    }

    private async void OnGetJokeClicked(object sender, EventArgs e)
    {
        try
        {
            var joke = await _jokeService.GetRandomJokeAsync();
            ChisteText.Text = $"{joke.Setup}\n\n{joke.Punchline}";
        }
        catch (Exception)
        {
            ChisteText.Text = "Ocurrió un error al obtener el chiste.";
        }
    }
}
