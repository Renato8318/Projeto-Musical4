using ConsoleApp1.Modelos;


namespace ConsoleApp1.Filtros
{
    internal class LinkOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica>musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistas ordenados");
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
