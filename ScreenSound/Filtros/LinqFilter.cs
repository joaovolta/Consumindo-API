using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    // Static é usado para indicar que o método pode ser chamado sem criar uma instância da classe.
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        // Select é usado para projetar cada elemento de uma coleção em um novo formato.
        // Neste caso, estamos selecionando o gênero de cada música.
        // Distinct é usado para remover duplicatas da coleção resultante.
        // ToList converte o resultado em uma lista.
        var todosOsGeneros = musicas.Select(musica => musica.Genero)
        .Distinct().ToList();

        // Exibe os gêneros musicais distintos encontrados na lista de músicas
        System.Console.WriteLine("Todos os gêneros musicais encontrados:");
        foreach (var genero in todosOsGeneros)
        {
            System.Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        // Where é usado para filtrar os elementos de uma coleção com base em uma condição especificada.
        // Neste caso, estamos filtrando as músicas cujo gênero contém o gênero especificado.
        // Contains é usado para verificar se uma string contém outra string.
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero))
        .Select(musica => musica.Artista).Distinct().ToList();

        System.Console.WriteLine("Artistas do genero >>> " + genero + ":");
        foreach (var artista in artistasPorGenero)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        // Where é usado para filtrar os elementos de uma coleção com base em uma condição especificada.
        // Neste caso, estamos filtrando as músicas cujo artista contém o nome do artista especificado.
        // Equals é usado para comparar strings para verificar se são iguais.
        var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista))
        .Select(musica => musica.Nome).Distinct().ToList();

        System.Console.WriteLine($"Músicas do artista >>> {artista}:");
        foreach (var musica in musicasPorArtista)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasPorAno = musicas.Where(musicas => musicas.Ano!.Equals(ano)).Select(musica => musica.Nome)
        .Distinct().ToList();

        System.Console.WriteLine($"Músicas do ano >>> {ano}:");
        foreach (var musica in musicasPorAno)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }
}