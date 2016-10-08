using AdminNetBaires.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{

    public class HomeController : Controller
    {
        //TODO: Paso 1 - Retornamos un ViewResult / |
        //Creo Views/Home/Index.cshtml
        public ViewResult Index()
        {
            //TODO: Paso 3 - Retorno un MemberViewModel / >
            //Construyo el Index.cshtml
            var memberTest = new MemberViewModel { Name = "Matias", LastName = "Apellido", Email = "matigas@gmail.com" };

            return View(memberTest);

        }
    }
}
