using ConsoleApp1.Modelos;
using System.Text.Json;
using ConsoleApp1.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinkFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinkOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinkFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
