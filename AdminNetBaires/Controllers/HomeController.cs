using AdminNetBaires.Services;
using AdminNetBaires.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{

    public class HomeController : Controller
    {
        private readonly IMembersService _membersService;
        private readonly IConfigService _configService;

        public HomeController(IMembersService membersService, IConfigService configService )
        {
            _membersService = membersService;
            _configService = configService;
        }
        public ViewResult Index()
        {
        
            return View();
        }
    }
}
