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
        public IActionResult Create([Bind("Id,Calification,Email,ExternaId,LastName,Name")] MemberViewModel member)
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

        //TODO : Paso 05 - Creo la action de edit y retorno la vista
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //TODO : Paso 06 - Creo la vista
            var model = _membersService.GetById(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(new MemberViewModel(model));

        }

        [HttpPost]
        public IActionResult Edit(int id, MemberViewModel model)
        {
            //TODO : Paso 08 - Genero un metodo post para la edicion
            var member = _membersService.GetById(id);
            if (member != null && ModelState.IsValid)
            {
                member.Name = model.Name;
                member.LastName = model.LastName;
                member.Email = model.Email;
                member.ExternaId = model.ExternaId;
                member.Calification = model.Calification;
                _membersService.Update(member);

                return RedirectToAction("Details", new { id = member.Id });
            }
            return View(model);
        }

    }
}
