using System.Text.Json;

namespace ScreenSound.Modelos;

internal class MusicasFavoritas
{
    public string Nome { get; set; }
    public List<Musica> ListaMusicasFavoritas { get; }

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaMusicasFavoritas = new();
    }

    public void AdicionarMusica(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicas()
    {
        System.Console.WriteLine("Lista de musicas favoritas -> " + Nome);
        foreach (var musica in ListaMusicasFavoritas)
        {
            System.Console.WriteLine($"- {musica.Nome} - {musica.Artista}");
        }
        System.Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        // JsonSerializer é usado para serializar o objeto em uma string JSON
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicasFavoritas
        });
        var nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        // File.WriteAllText é usado para escrever o conteúdo do JSON em um arquivo com o nome especificado
        // GetFullPath é usado para obter o caminho completo do arquivo gerado
        System.Console.WriteLine($"Arquivo JSON gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}