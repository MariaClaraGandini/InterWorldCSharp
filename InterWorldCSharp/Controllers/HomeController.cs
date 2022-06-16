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
            model.Add(new CidadeModel() { pais = "Estados Unidos",
                cidade1 = "Boston", cidade1p = "Localizada no estado de  Massachusetts, Boston é reconhecida por ser o berço da independência americana. Culturalmente diversa, a cidade possui expressivo número de imigrantes irlandeses e portugueses.", img1 = "travel/img1.png",
                cidade2 = "Nova Iorque", cidade2p = "Nova Iorque é a maior cidade dos Estados Unidos. Da população local, 40% é estrangeira e se fala mais de 80 idiomas diferentes. Não é à toa que Nova York é sede de várias empresas e organizações do mundo.", img2 = "travel/img2.png",
                cidade3 = "Chicago", cidade3p = "Conhecida como a “Cidade dos Ventos”, Chicago surpreende pela diversidade. Reunindo o maior número de parques e praças dos Estados Unidos e reconhecida internacionalmente pela qualidade e modernidade de sua arquitetura, a cidade alia natureza e desenvolvimento.", img3 = "travel/img3.png",
            cidade4 = "Los Angeles", cidade4p = "Los Angeles é a cidade mais importante da Califórnia, sendo líder na produção de filmes, séries e músicas. Com inúmeras praias, pontos turísticos e arranha-céus, ela se destaca como uma cidade cheia de atrações para os mais diversos estilos.", img4 = "travel/img4.png" });

            model.Add(new CidadeModel()
            {
                pais = "Canada",
                cidade1 = "Toronto",
                cidade1p = "Cosmopolita, multicultural e com vida noturna agitada, atividades é o que não faltam nessa metrópole, que além dessas qualidades, possui um alto índice de qualidade de vida e segurança.Possui  uma estrutura educacional de primeiro mundo e é uma das cidades mais multiculturais do planeta",
                img1 = "travel/img5-toronto.png",

                cidade2 = "Montreal",
                cidade2p = "É um grande centro industrial, comercial e universitário.A cidade é considerada uma das cidades mais seguras do mundo, com um povo super educado e com a maior concentração de estudantes da América do Norte.Montreal também é a segunda maior cidade de falantes de língua francesa no mundo.",
                img2 = "travel/img6-montreal.png",

                cidade3 = "Victoria",
                cidade3p = "Victoria fica na ilha de Vancouver Island e é a capital do estado de British Columbia.A cidade tem um clima europeu e é conhecida como “A Cidade dos Jardins” devido aos lindos e coloridos jardins que estão espalhados por toda a cidade.",
                img3 = "travel/img7-victoria.png",

                cidade4 = "Vancouver",
                cidade4p = "Foi eleita em 2018 como a melhor cidade para se viver da América do Norte e a 5ª melhor do mundo. A Mercer (uma empresa internacional de consultoria) foi responsável por esse ranking e levou em conta fatores como segurança pessoal, estabilidade, níveis de criminalidade e desempenho da aplicação da lei local.",
                img4 = "travel/img8-vancouver.jpg",
            });
            model.Add(new CidadeModel()
            {
                pais = "Inglaterra",
                cidade1 = "Londres",
                cidade1p = "A capital da Inglaterra abriga o Palácio de Buckingham que é a residência oficial da realeza britânica, o Parlamento Inglês juntamente com o famoso relógio Big Ben, a London Eye, entre muitos outros atrativos. No entanto, é andando pelas ruas de mão inglesa ou no metrô mais antigo do mundo que você verá a vida londrina acontecer.",
                img1 = "travel/img9-londres.png",

                cidade2 = "Liverpool",
                cidade2p = "A cidade dos Beatles é repleta de museus e galerias de arte, sendo considerado o segundo polo cultural da Inglaterra. Ainda na região portuária, em frente ao rio Mersey, há a chamada Liverpool Waterfront, ou Pier Head, podemos encontrar as estátuas dos Beatles que, claro, não podem faltar em nenhum roteiro. Vale a pena a visita!",
                img2 = "travel/img10-liverpool.png",

                cidade3 = "Birmingham",
                cidade3p = "A segunda maior cidade da Inglaterra, situada na região central conhecida por Midlands, Birmingham chama atenção por sua história na Revolução Industrial, lugares interessantes para conhecer e perfeita para quem gosta da série Peaky Blinders. Amantes da música também curtem, já que algumas bandas nasceram aqui como Black Sabbath, Judas Priest e Duran Duran.",
                img3 = "travel/img11-birmingham.png",

                cidade4 = "Cambridge",
                cidade4p = "Cerca de 20% da população local é formada por estudantes entre universitários e intercambistas. A Universidade de Cambridge também é muito famosa por ser considerada durante muitos anos consecutivos uma das melhores universidades do mundo. Nomes como Isaac Newton, Stephen Hawking e Charles Darwin passaram por lá. ",
                img4 = "travel/img12.png"
            });

            model.Add(new CidadeModel() { pais = "Espanha",
                cidade1 = "Madrid",
                cidade1p = "Para quem gosta de arte e história, a cidade é cheia de imponentes construções históricas e museus com os principais acervos da Europa. De dia, você pode também passear e fazer compras pela Gran Vía, conhecer os Parques El Retiro e o Templo de Debod, onde muitos dizem ser o melhor lugar para ver o pôr-do-sol na cidade.",
                img1 = "travel/img13.png",

                cidade2 = "Barcelona",
                cidade2p = "Um dos principais centros turísticos e econômicos do país, Barcelona atrai milhões de visitantes todos os anos. O clima mediterrâneo é muito agradável e propício para conhecer a cidade a pé ou de bicicleta. A cidade está diretamente ligada ao arquiteto Gaudí, famoso pela construção da Sagrada Família, Parc Guell e La Pedrera.",
                img2 = "travel/img14.png",

                cidade3 = "Sevilha",
                cidade3p = "O que não falta em Sevilha são atrações históricas. A cidade tem um pas­sado riquíssimo, foi controlada pelos árabes e, mais recentemente, pelos cristãos, povos estes que deixaram um legado arquitetônico incomparável.  A catedral de Sevilha é um verdadeiro monumento à glória cristã, é a terceira maior igreja do mundo e levou mais de um século para ser ter­minada.",
                img3 = "travel/img15.png",

                cidade4 = "Granada",
                cidade4p = "Fontes, mirantes e Cármenes, as casas rodeadas de jardins que são características desta cidade, contribuem para criar lugares inesquecíveis. Não é à toa que um de seus bairros antigos, o Albaicín, é Patrimônio da Humanidade junto com La Alhambra e o Generalife. Importante centro cultural durante vários séculos, tanto durante o governo muçulmano como o cristão, Granada goza atualmente de uma invejável agenda cultural e de lazer.",
                img4 = "travel/img16.png",
            });
            model.Add(new CidadeModel()
            {
                pais = "França",
                cidade1 = "Paris",
                cidade1p = "Considerada uma das cidades mais românticas do mundo, Paris é sem dúvidas um destino que tem muito a oferecer. Além de um conjunto arquitetônico de tirar o fôlego, monumentos imponentes e jardins floridos, a gastronomia de primeira com certeza conquistar qualquer viajante.",
                img1 = "travel/img17.png",

                cidade2 = "Marselha",
                cidade2p = "Edifícios de arquitetura inovadora. Hotelaria e gastronomia excelentes. E 2.600 anos de herança histórica. Esta é Marselha, a segunda maior – e a mais antiga – cidade da França. Localizada a 776 quilômetros da capital, ela surgiu em 600 a.C., por obra dos gregos.",
                img2 = "travel/img18.png",

                cidade3 = "Lyon",
                cidade3p = "Fazer intercâmbio em Lyon é viver em uma cidade que oferece todos os privilégios da vida na França, porém sem o estresse característico de uma capital. Com pouco mais de 500 mil habitantes, Lyon está situada na histórica região Rhône-Alpes e é a terceira maior cidade do país.",
                img3 = "travel/img19.png",

                cidade4 = "Nice",
                cidade4p = "Cidade litorânea, localizada ao sul da França, é um dos destinos mais procurados do país. Ensolarada praticamente o ano inteiro, recebe em média 4 milhões de turistas ao longo do ano, que vão atrás de suas belíssimas praias e paisagens.Situada perto de cidades importantes como Marselha e Cannes, está também próxima de Mônaco e da fronteira com a Itália, permitindo vários passeios interessantes aos finais de semana.",
                img4 = "travel/img20.png",
            });

   
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
