using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
       
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }
    
    [HttpPost]
    public IActionResult Generar(string palo,string numero, string palo1, string numero1, string palo2, string numero2, string palo3, string numero3, string palo4, string numero4)
    {
        List<Carta> lista = new List<Carta>()
        {
            new Carta
            {
                Palo = palo,
                Numero = int.Parse(numero),
            },
            new Carta
            {
                Palo = palo1,
                Numero = int.Parse(numero1),
            },
            new Carta
            {
                Palo = palo2,
                Numero = int.Parse(numero2),
            },
            new Carta
            {
                Palo = palo3,
                Numero = int.Parse(numero3),
            },
            new Carta
            {
                Palo = palo4,
                Numero = int.Parse(numero4),
            },
        };
        var service = new PokerService();
        ViewBag.Jugada = service.GetJugada(lista);
        return View("Index", lista);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}