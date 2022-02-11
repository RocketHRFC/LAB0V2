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
        Cliente cliente5;
        Cliente cliente6;
        Cliente cliente7;
        Cliente cliente8;
        Cliente cliente9;
        Cliente cliente10;
        List<Cliente> ListaClientes;
        List<Cliente> ListaClientes2;

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
            cliente5 = new Cliente
            {
                Nombre = "Adrian", 
                Apellido="Garavito",
                Telefono = 789456123,
                Detalles="cliente5"
            };
            cliente6 = new Cliente
            {
                Nombre="Eduardo",
                Apellido="Lopez",
                Telefono=456789123,
                Detalles="cliente6",
            };
            cliente7 = new Cliente
            {
                Nombre="Rodrigo",
                Apellido="Palma",
                Telefono=127984565,
                Detalles="cliente7",
            };
            cliente8 = new Cliente
            {
                Nombre="Adham",
                Apellido="Aranki",
                Telefono=1845658456,
                Detalles="cliente8",
            };
            cliente9 = new Cliente
            {
                Nombre="Fernando",
                Apellido="Lopez",
                Telefono=18456556,
                Detalles="cliente9",
            };
            cliente10 = new Cliente
            {
                Nombre="Alonso",
                Apellido="Velasquez",
                Telefono=153858456,
                Detalles="cliente10",
            };
          
            ListaClientes = new List<Cliente>();
            ListaClientes2 = new List<Cliente>();
            ListaClientes.Add(cliente1);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);
            ListaClientes.Add(cliente4);
            ListaClientes.Add(cliente5);
            ListaClientes.Add(cliente6);
            ListaClientes.Add(cliente7);
            ListaClientes.Add(cliente8);
            ListaClientes.Add(cliente9);
            ListaClientes.Add(cliente10);

            ListaClientes2.Add(cliente1);
            ListaClientes2.Add(cliente2);
            ListaClientes2.Add(cliente3);
            ListaClientes2.Add(cliente4);
            ListaClientes2.Add(cliente5);
            ListaClientes2.Add(cliente6);
            ListaClientes2.Add(cliente7);
            ListaClientes2.Add(cliente8);
            ListaClientes2.Add(cliente9);
            ListaClientes2.Add(cliente10);


            void ModBubbleSortNombre(ref List<Cliente> lista)
            {
                Cliente aux;
                int n = lista.Count;
                int i = 1;
                bool bandera = false;
                while (bandera == false && i < n)
                {
                    bandera = true;
                    for (int j = 0; j < (n - i); j++)
                    {
                        if (booleano(lista[j].Nombre, lista[j + 1].Nombre))
                        {
                            aux = lista[j];
                            lista[j] = lista[j + 1];
                            lista[j + 1] = aux;
                            bandera = false;
                        }
                    }
                    i = i + 1;
                }

            }
            void ModBubbleSortApellido(ref List<Cliente> lista)
            {
                Cliente aux;
                int n = lista.Count;
                int i = 1;
                bool bandera = false;
                while (bandera == false && i < n)
                {
                    bandera = true;
                    for (int j = 0; j < (n - i); j++)
                    {
                        if (booleano(lista[j].Apellido, lista[j + 1].Apellido))
                        {
                            aux = lista[j];
                            lista[j] = lista[j + 1];
                            lista[j + 1] = aux;
                            bandera = false;
                        }
                    }
                    i = i + 1;
                }

            }
            bool booleano(string string1, string string2)
            {
                string newString1 = string1.ToUpper();
                string newString2 = string2.ToUpper();
                if (newString1.CompareTo(newString2) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            ModBubbleSortApellido(ref ListaClientes);
            ModBubbleSortNombre(ref ListaClientes2);
        }

        public List<Cliente> ListaApellido()
        {
            return ListaClientes;
        }

        public List<Cliente> ListaNombres()
        {
            return ListaClientes2;
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