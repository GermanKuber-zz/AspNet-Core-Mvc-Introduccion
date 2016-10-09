using AdminNetBaires.Services;
using AdminNetBaires.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{

    public class HomeController : Controller
    {
        private readonly IMembersService _membersService;
        private readonly IConfigService _configService;

        //TODO : Paso 3 - Inyecto mi config Service
        public HomeController(IMembersService membersService, IConfigService configService )
        {
            _membersService = membersService;
            _configService = configService;
        }
        public ViewResult Index()
        {
            //TODO : Paso 4 - Retorno un HomePageViewModel
          
            var homeViewModel = new HomePageViewModel
            {
                Members = _membersService.GetAll(),
                Message = this._configService.GetHello()

            };
            //TODO : Paso 5 - Construyo Vista
            return View(homeViewModel);

        }
    }
}
