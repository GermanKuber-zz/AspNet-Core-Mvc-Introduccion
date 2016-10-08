using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{
    //TODO : Paso 1 - Heredo de Controller /  >
    public class HomeController : Controller
    {
        //TODO : Paso 2 - Retorno la Interface IActionResult  /  |*>
        public IActionResult Index()
        //TODO : Paso 3 - Implemento ObjectResult  /  |
        //public ObjectResult Index()
        {
            //Paso 2
            return Content("Hello World !! - Desde un controller de Mvc!!");

            //Paso 3
            //return new ObjectResult(new { Nombre = "Matias", Facultad = "UTN", Email = "matigas@gmail.com" });


        }
    }
}
