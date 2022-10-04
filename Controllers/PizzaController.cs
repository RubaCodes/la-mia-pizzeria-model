using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> menu = new List<Pizza>();
            Pizza margherita = new Pizza("Margherita", "Pomodoro, Mozzarella", "/img/pizza-photos/margherita.jpg", 8.00m);
            Pizza diavola = new Pizza("Diavola", "Pomodoro, Mozzarella, Salamino piccante", "/img/pizza-photos/diavola.jpg", 10m);
            Pizza quattroStagioni = new Pizza("4 Stagioni", "Pomodoro, Mozzarella, Prosciutto Cotto, Funghi, Carciofini, Olive Nere", "/img/pizza-photos/quattro-stagioni.jpg", 12m);
            Pizza quattroFormaggi = new Pizza("4 Formaggi", "Pomodoro, Mozzarella, Gorgonzola, Scamorza, Grana", "/img/pizza-photos/quattro-formaggi.jpg", 9m);

            menu.Add(margherita);
            menu.Add(diavola);
            menu.Add(quattroStagioni);
            menu.Add(quattroFormaggi);

            return View(menu);
        }
    }
}