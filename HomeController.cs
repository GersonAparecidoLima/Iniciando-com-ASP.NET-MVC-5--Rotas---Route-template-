using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Paramentro.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        //Route usando {} e por que estamos passando paramentro
        //[Route(template: "{pa}")]
       // [Route(template: "{pa:int}/texto:maxlength(50)")]
       // public ActionResult About(in pa, string texto)
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //public ActionResult Contact(int teste)
        // o erro ocorre por que o nome do paramentro e teste
        // por que o parametro com nome teste não e nomeado
        // então para funcionar temos que usar a url
        // https:/ /localhost:44369/Home/Contact?teste=1 ==> neste caso e parte da rota ou valor dinamico
        // e não um parametro estruturado,
        // mas voltando para paramentro nomeado coom visto RouteConfig.cs
        // que no C:\Users\CATALOG\source\repos\Paramentro\Paramentro\App_Start\RouteConfig.cs
        // temos o nome id por que e o que esta na rota
        public ActionResult Contact(int teste)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}