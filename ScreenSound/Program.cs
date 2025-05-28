using System.Net.WebSockets;
using System.Text.Json;
using ScreenSound.Modelos;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        System.Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // JsonSerializer é usado para desserializar o JSON em uma lista de objetos Musica
        musicas[0].ExibirDetalhes(); // Exibe os detalhes da primeira música
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro ao obter a resposta: {ex.Message}");
    }
}