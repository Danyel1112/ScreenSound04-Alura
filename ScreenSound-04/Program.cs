using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync
            ("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Billie Eilish");


        //var musicasPreferidas = new MusicasPreferidas("Daniel");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        //var musicasPreferidasMinha = new MusicasPreferidas("Emy");

        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[1998]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[593]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[213]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[656]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[323]);

        //musicasPreferidasMinha.ExibirMusicasFavoritas();

        //musicasPreferidasMinha.GerarArquivoJson();

    }
     catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}