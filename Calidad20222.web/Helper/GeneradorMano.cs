using Calidad20222.web.Models;

namespace Calidad20222.web.Helper;

public class GeneradorMano
{
    public static List<Carta> Generar()
    {
        var rng = new Random();
        var shuffledcards = Carta.Todas().OrderBy(a => rng.Next()).ToList();
        return shuffledcards.Skip(0).Take(5).ToList();
    }
}