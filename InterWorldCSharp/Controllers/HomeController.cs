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
            List<SliderModel> model = new List<SliderModel>();
            model.Add(new SliderModel() { titulo1 = "Faça o seu intercâmbio",titulo2="em 2022", descricao1 = "teste", sliderimg="home/slider.png"});
            return View(model);
        }

        public IActionResult Destinations()
        {

            List<CidadeModel> model = new List<CidadeModel>();
            model.Add(new CidadeModel() { nome = "Boston", cidade1= "Localizada no estado de  Massachusetts, Boston é reconhecida por ser o berço da independência americana. Culturalmente diversa, a cidade possui expressivo número de imigrantes irlandeses e portugueses.", pais = "United States" ,img1="travel/img1.png", img2 = "travel/img2.png", img3 = "trave/img3.png" });
            model.Add(new CidadeModel() { nome = "matao", cidade1= "", pais = "Canada", });
            model.Add(new CidadeModel() { nome = "itaolis", cidade1 = "cidade pequena", pais = "Brasil", img1="img3.png"});
            model.Add(new CidadeModel() { nome = "avare", cidade1 = "cidade pequena", pais = "Brasil", img4="img4.png"});
            model.Add(new CidadeModel() { nome = "sp", cidade1 = "cidade pequena", pais = "Brasil", img1="img5-toronto.png" });
            model.Add(new CidadeModel() { nome = "btu", cidade1 = "cidade pequena", pais = "Brasil" , img2="img6.montreal.png"});
            model.Add(new CidadeModel() { nome = "araraqyuara", cidade1 = "cidade pequena", pais = "Brasil", img1="download.jpg" });
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
