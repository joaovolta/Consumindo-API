using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{
    // JsonPropertyName é usado para mapear as propriedades do JSON para as propriedades da classe
    // Isso é necessário quando os nomes das propriedades no JSON não correspondem exatamente aos nomes das propriedades na classe
    [JsonPropertyName("song")]
    public string? Nome { get; set; } // ? significa que a propriedade pode ser nula
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao} ms");
        System.Console.WriteLine($"Gênero: {Genero}");
        System.Console.WriteLine($"Ano: {Ano}");
    }
}