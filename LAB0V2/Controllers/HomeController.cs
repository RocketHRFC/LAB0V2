using LAB0V2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAB0V2.Controllers
{
    public class HomeController : Controller
    {
        Cliente cliente1;
        Cliente cliente2;
        Cliente cliente3;
        Cliente cliente4;
        List<Cliente> ListaClientes;

        public HomeController(ILogger<HomeController> logger)
        {
            cliente1 = new Cliente
            {
                Nombre = "Mario",
                Apellido = "Aranki",
                Telefono = 12436,
                Detalles = "cliente1"
            };
            cliente2 = new Cliente
            {
                Nombre = "Marcus",
                Apellido = "Flores",
                Telefono = 12536,
                Detalles = "cliente2"
            };
            cliente3 = new Cliente
            {
                Nombre = "Edio",
                Apellido = "Ramos",
                Telefono = 12436,
                Detalles = "cliente3"
            };
            cliente4 = new Cliente
            {
                Nombre = "Marlon",
                Apellido = "Perez",
                Telefono = 12436,
                Detalles = "cliente4"
            };

            ListaClientes = new List<Cliente>();
            ListaClientes.Add(cliente1);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);
            ListaClientes.Add(cliente4);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}