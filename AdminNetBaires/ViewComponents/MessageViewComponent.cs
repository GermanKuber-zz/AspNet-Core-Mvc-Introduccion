using AdminNetBaires.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.ViewComponents
{
    //TODO : Paso 4 - Implemento una clase ViewModel

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
    //TODO : Paso 5 - Creo Shared/Components/Message/Default.cshtml
    //TODO : Paso 6 - Llamo a mi Component desde _Layout

}
