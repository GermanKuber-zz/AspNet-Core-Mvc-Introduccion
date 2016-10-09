using AdminNetBaires.Services;
using AdminNetBaires.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{
    //TODO : Paso 1 - Creo el controlador de members
    public class MembersController : Controller
    {
        private readonly IMembersService _membersService;

        //TODO : Paso 4 - Inyecto mi servicio / >
        public MembersController(IMembersService membersService)
        {
            _membersService = membersService;
        }


        public ViewResult Index()
        {

            var homeViewModel = new MembersIndexViewModel
            {
                Members = _membersService.GetAll()

            };
            return View(homeViewModel);
        }

        //TODO : Paso 2 - Pruebo mi controller / |*>
        // Navego : /members/details/3
        //Navego : /members/details? id = 2
        //public string Details(int id)
        //TODO : Paso 3 - Retorno Un IActionResult / >
        public IActionResult Details(int id)
        {
            //TODO : Paso 5 - Obtengo el member / >
            var result = this._membersService.GetById(id);

            //TODO : Paso 8 - Controlo error / |>
            if (result == null)
            {
                return RedirectToAction("Index");
            }
            //TODO : Paso 6 - Implemento la Vista / |>
            return View(result);
        }
    }
}
