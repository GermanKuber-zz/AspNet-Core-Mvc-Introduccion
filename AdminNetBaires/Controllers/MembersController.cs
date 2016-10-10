using System.Linq;
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
                Members = _membersService.GetAll()?.Select(x=> new MemberViewModel(x))

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
        public IActionResult Create([Bind("Id,Calification,Email,ExternaId,LastName,Name,Image")] MemberViewModel member)
        {


            if (ModelState.IsValid)
            {
                var newObj = new Member
                {
                    Email = member.Email,
                    LastName = member.LastName,
                    Name = member.Name,
                    Calification = member.Calification,
                    ExternaId = member.ExternaId,
                    Image = member.Image
                };
                this._membersService.Create(newObj);
                this._membersService.Commit();
                return RedirectToAction("Details", new { id = newObj.Id });

            }
            return View();

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
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
            var member = _membersService.GetById(id);
            if (member != null && ModelState.IsValid)
            {
                member.Name = model.Name;
                member.LastName = model.LastName;
                member.Email = model.Email;
                member.Image = model.Image;
                member.ExternaId = model.ExternaId;
                member.Calification = model.Calification;
                //TODO : Paso 6 - Consumo el metodo commit
                _membersService.Commit();

                return RedirectToAction("Details", new { id = member.Id });
            }
            return View(model);
        }

    }
}
