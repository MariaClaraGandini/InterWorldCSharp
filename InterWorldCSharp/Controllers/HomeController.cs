using InterWorldCSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InterWorldCSharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destinations()
        {
            List<CidadeModel> model = new List<CidadeModel>();
            model.Add(new CidadeModel() { Nome = "Taquaritinga", descricao = "cidade pequena", pais = "Brasil" });
            model.Add(new CidadeModel() { Nome = "matao", descricao = "cidade pequena", pais = "Brasil" });
            model.Add(new CidadeModel() { Nome = "itaolis", descricao = "cidade pequena", pais = "Brasil" });
            model.Add(new CidadeModel() { Nome = "avare", descricao = "cidade pequena", pais = "Brasil" });
            model.Add(new CidadeModel() { Nome = "sp", descricao = "cidade pequena", pais = "Brasil" });
            model.Add(new CidadeModel() { Nome = "btu", descricao = "cidade pequena", pais = "Brasil" });
            model.Add(new CidadeModel() { Nome = "araraqyuara", descricao = "cidade pequena", pais = "Brasil", img="download.jpg" });
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Budget()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult SignUp()
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
