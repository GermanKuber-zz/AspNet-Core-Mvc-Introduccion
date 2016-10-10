using AdminNetBaires.Entities;
using AdminNetBaires.Services;
using AdminNetBaires.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{
   
    public class MembersController : Controller
    {
        private readonly IMembersService _membersService;
        
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


        public IActionResult Details(int id)
        {
           
            var result = this._membersService.GetById(id);
            if (result == null)
            {
                return RedirectToAction("Index");
            }
       
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Calification,Email,ExternaId,LastName,Name")] MemberViewModel member)
        {
          
        
            if (ModelState.IsValid)
            {
                var newObj = new Member
                {
                    Email = member.Email,
                    LastName = member.LastName,
                    Name = member.Name,
                    Calification = member.Calification,
                    ExternaId = member.ExternaId
                };
                this._membersService.Create(newObj);
                return RedirectToAction("Details", new { id = newObj.Id });
              
            }
            return View();
         
        }
    }
}
