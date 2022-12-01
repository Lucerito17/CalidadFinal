using Calidad20222.web.Models;

namespace Calidad20222.web.Services;

public class PokerService
{   
    public const String CARTA_MAYOR = "CARTA MAYOR";
    public const String DOBLE = "DOBLE";
    public const String DOBLE_PAREJA = "DOBLE PAREJA";
    public const String TRIO = "TRIO";
    public const String ESCALERA = "ESCALERA";
    public const String COLOR = "COLOR";
    public const String FULL = "FULL";
    public const String POKER = "POKER";
    public const String ESCALERA_COLOR = "ESCALERA COLOR";
    public const String ESCALERA_REAL = "ESCALERA REAL";

    public String GetJugada(List<Carta> cartas)
    {
        if (EsEscaleraReal(cartas))
            return ESCALERA_REAL;
        if (EsEscaleraColor(cartas))
            return ESCALERA_COLOR;
        if (EsPoker(cartas))
            return POKER;
        if (EsFull(cartas))
            return FULL;
        if (EsColor(cartas))
            return COLOR;
        if (EsEscalera(cartas))
            return ESCALERA;
        if (EsTrio(cartas))
            return TRIO;
        if (EsDoblePareja(cartas))
            return DOBLE_PAREJA;
        if (EsDoble(cartas))
            return DOBLE;

        return CARTA_MAYOR;
    }

    private bool EsColor(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Palo);
        return grouping.Count() == 1;
    }

    private bool EsEscalera(List<Carta> cartas)
    {
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        for (var i = 0; i < cartas.Count - 1; i++)
        {
            if (cartas.ElementAt(i).Numero + 1 != cartas.ElementAt(i + 1).Numero)
                return false;
        }

        return true;
    }

    private bool EsFull(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 2;
    }
    private bool EsDoblePareja(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 3;
    }

    private bool EsPoker(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 3);
    }
    
    private bool EsTrio(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 2);
    }

    private bool EsDoble(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 1);
    }

    private bool EsEscaleraColor(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Palo);
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        if (grouping.Count() > 1)
            return false;
        for (var i = 0; i < cartas.Count - 1; i++)
        {
            if (cartas.ElementAt(0).Numero == 1 && cartas.ElementAt(1).Numero == 10 &&
                cartas.ElementAt(2).Numero == 11 && cartas.ElementAt(3).Numero == 12 &&
                cartas.ElementAt(4).Numero == 13 && cartas.ElementAt(5).Numero == 10 &&
                cartas.ElementAt(6).Numero == 9 && cartas.ElementAt(7).Numero == 8 &&
                cartas.ElementAt(8).Numero == 7 && cartas.ElementAt(9).Numero == 6 &&
                cartas.ElementAt(10).Numero == 5 && cartas.ElementAt(11).Numero == 4 &&
                cartas.ElementAt(12).Numero == 3 && cartas.ElementAt(13).Numero == 2)
                return true;
            if (cartas.ElementAt(i).Numero + 1 != cartas.ElementAt(i + 1).Numero)
                return false;
        }
        return true;
    }

    private bool EsEscaleraReal(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Palo);
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        if (cartas.ElementAt(0).Numero == 1 && cartas.ElementAt(1).Numero == 10 && 
            cartas.ElementAt(2).Numero == 11 && cartas.ElementAt(3).Numero == 12 && 
            cartas.ElementAt(4).Numero == 13 && grouping.Count() == 1)
            return true;
        return false;
    }
}