namespace Calidad20222.web.Models;

public class Jugador
{
    public int Id { get; set; }
    public String Nombre { get; set; } 
    public List<Carta> Cartas { get; set; }
}