using AdminNetBaires.Models;
using AdminNetBaires.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{

    public class HomeController : Controller
    {
        private readonly IMembersService _membersService;

        //TODO : Paso 3 - Inyecto el servicio
        public HomeController(IMembersService membersService )
        {
            _membersService = membersService;
        }
        public ViewResult Index()
        {
            //TODO : Paso 4 - Envio los datos a la vista
            return View(_membersService.GetAll());

        }
    }
}
