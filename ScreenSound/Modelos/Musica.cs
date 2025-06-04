using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{
    // tonaliades é um array de strings que contém as tonalidades musicais
    private string[] tonalidades = new[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
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
    [JsonPropertyName("key")]
    public int Key { get; set; }
    // A propriedade Tonalidade retorna a tonalidade musical correspondente ao valor de Key
    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao} ms");
        System.Console.WriteLine($"Gênero: {Genero}");
        System.Console.WriteLine($"Ano: {Ano}");
        System.Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}