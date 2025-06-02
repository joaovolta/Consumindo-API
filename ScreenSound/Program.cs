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
        // LinqFilter.FiltrarMusicasPorAno(musicas, "2004"); // Chama o método para filtrar e exibir músicas por ano

        // MusicasFavoritas musicasFavoritasJoao = new MusicasFavoritas("João");

        // musicasFavoritasJoao.AdicionarMusica(musicas[50]);
        // musicasFavoritasJoao.AdicionarMusica(musicas[678]);
        // musicasFavoritasJoao.AdicionarMusica(musicas[123]);
        // musicasFavoritasJoao.AdicionarMusica(musicas[456]);
        // musicasFavoritasJoao.AdicionarMusica(musicas[1248]);

        // musicasFavoritasJoao.ExibirMusicas(); // Exibe as músicas favoritas de João

        MusicasFavoritas musicasFavoritasJulia = new MusicasFavoritas("Julia");

        musicasFavoritasJulia.AdicionarMusica(musicas[41]);
        musicasFavoritasJulia.AdicionarMusica(musicas[891]);
        musicasFavoritasJulia.AdicionarMusica(musicas[1892]);
        musicasFavoritasJulia.AdicionarMusica(musicas[1432]);
        musicasFavoritasJulia.AdicionarMusica(musicas[674]);

        musicasFavoritasJulia.ExibirMusicas(); // Exibe as músicas favoritas de Julia

        musicasFavoritasJulia.GerarArquivoJson(); // Gera um arquivo JSON com as músicas favoritas de Julia
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro ao obter a resposta: {ex.Message}");
    }
}