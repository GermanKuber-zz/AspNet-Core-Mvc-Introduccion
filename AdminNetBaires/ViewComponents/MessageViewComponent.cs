using AdminNetBaires.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.ViewComponents
{

    public class MessageViewComponent : ViewComponent
    {
        private readonly IConfigService _configService;


        public MessageViewComponent(IConfigService configService)
        {
            _configService = configService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _configService.GetHello();
            return View("Default", model);
        }
    }
}
