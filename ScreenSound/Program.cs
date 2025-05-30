using System.Net.WebSockets;
using System.Text.Json;
using ScreenSound.Filtros;
using ScreenSound.Modelos;

// Linq é uma abreviação para Language Integrated Query, que é uma maneira de consultar coleções de dados em C# usando uma sintaxe semelhante ao SQL.
// HttpClient é usado para fazer solicitações HTTP e obter dados de uma URL.

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // JsonSerializer é usado para desserializar o JSON em uma lista de objetos Musica
        // Desserialização é o processo de converter uma representação em JSON de um objeto em uma instância do objeto em C#.
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); // Chama o método para filtrar e exibir os gêneros musicais distintos
        // LinqOrder.ExibirListaDeArtistasPorOrdem(musicas); // Chama o método para exibir a lista de artistas em ordem alfabética
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop"); // Chama o método para filtrar e exibir artistas por gênero musical
        // LinqFilter.FiltrarMusicasPorArtista(musicas, "Snoop Dogg"); // Chama o método para filtrar e exibir músicas por artista
        LinqFilter.FiltrarMusicasPorAno(musicas, "2004"); // Chama o método para filtrar e exibir músicas por ano
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro ao obter a resposta: {ex.Message}");
    }
}