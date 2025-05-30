using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasPorOrdem(List<Musica> musicas)
    {
        // OrderBy é usado para ordenar os elementos de uma coleção com base em uma chave especificada.
        // Neste caso, estamos ordenando as músicas pelo nome do artista.
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
        .Select(musica => musica.Artista).Distinct().ToList();

        System.Console.WriteLine("Lista de artistas ordenados por ordem alfabética:");
        foreach (var artista in artistasOrdenados)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }
}